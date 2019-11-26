using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelEngine
{
    public class Font
    {
        internal Dictionary<char, Sprite> Glyphs;
        internal int CharHeight;
        internal static Dictionary<string, Font> UserFonts = new Dictionary<string, Font>();

        private Font() => Glyphs = new Dictionary<char, Sprite>();

        internal Font(Dictionary<char, Sprite> glyphs)
        {
            Glyphs = glyphs;
            CharHeight = glyphs.Values.Max(g => g.Height);
        }

        public int TextWidth(char c) => Glyphs[c].Width;

        public int TextWidth(string text) => text.Length > 1
            ? text.Sum(c => Glyphs[c].Width)
            : text.Length == 1
                ? TextWidth(text[0])
                : 0;

        public int TextHeight(char c) => Glyphs[c].Height;

        public int TextHeight(string text) => (text.Count(c => c == '\n') + 1) * CharHeight;

        static Font()
        {
            ResxHelper.LoadFonts();
            retro = new Lazy<Font>(CreateRetro);
            modern = new Lazy<Font>(CreateModern);
            formal = new Lazy<Font>(CreateFormal);
            handwritten = new Lazy<Font>(CreateHandwritten);
        }

        private static Font LoadFont(int width, int height, string path)
        {
            Font f = new Font();
            f.CharHeight = height;

            Sprite spr = Sprite.Load(path);

            for (char cur = ' '; cur < 128; cur++)
            {
                Sprite fontChar = new Sprite(width, height);

                int x = (cur - 32) % 16;
                int y = (cur - 32) / 16;

                for (int i = 0; i < width; i++)
                    for (int j = 0; j < height; j++)
                        fontChar[i, j] = spr[x * width + i, y * height + j];

                f.Glyphs.Add(cur, fontChar);
            }

            return f;
        }

        private static Font LoadFont(int width, int height, string path, string dataPath)
        {
            Font f = new Font();
            f.CharHeight = height;

            Sprite spr = Sprite.Load(path);

            using (FileStream stream = File.OpenRead(dataPath))
            using (BinaryReader reader = new BinaryReader(stream))
            {
                reader.ReadBytes(16); // Offset 16 + 32
                reader.ReadBytes(33); // bytes into data

                byte[] widths = reader.ReadBytes(96); // widths of 96 ascii chars

                for (char cur = ' '; cur < 128; cur++)
                {
                    byte w = widths[cur - 32];
                    Sprite fontChar = new Sprite(w, height);

                    int x = (cur - 32) % 16;
                    int y = (cur - 32) / 16;

                    for (int i = 0; i < w; i++)
                        for (int j = 0; j < height; j++)
                            fontChar[i, j] = spr[x * width + i, y * height + j];

                    f.Glyphs.Add(cur, fontChar);
                }
            }

            return f;
        }

        #region Presets

        private static Font CreateRetro()
        {
            return LoadFont(8, 8, Windows.TempPath + "\\Retro.png");
        }

        private static Font CreateModern()
        {
            return LoadFont(16, 21, Windows.TempPath + "\\Modern.png", Windows.TempPath + "\\Modern.dat");
        }

        private static Font CreateFormal()
        {
            return LoadFont(16, 21, Windows.TempPath + "\\Formal.png", Windows.TempPath + "\\Formal.dat");
        }

        private static Font CreateHandwritten()
        {
            return LoadFont(16, 21, Windows.TempPath + "\\Handwritten.png", Windows.TempPath + "\\Handwritten.dat");
        }

        private static readonly Lazy<Font> retro;
        private static readonly Lazy<Font> modern;
        private static readonly Lazy<Font> formal;
        private static readonly Lazy<Font> handwritten;

        public enum Presets
        {
            Retro,
            Modern,
            Formal,
            Handwritten
        }

        public static implicit operator Font(Presets p)
        {
            switch (p)
            {
                case Presets.Retro:
                    return retro.Value;
                case Presets.Modern:
                    return modern.Value;
                case Presets.Formal:
                    return formal.Value;
                case Presets.Handwritten:
                    return handwritten.Value;
            }

            return null;
        }

        #endregion

        #region User Fonts

        public static Font LoadFont(string name, int width, int height, string path)
        {
            var font = LoadFont(width, height, path);
            UserFonts.Add(name, font);
            return font;
        }

        public static Font LoadFont(string name, int width, int height, string path, string dataPath)
        {
            var font = LoadFont(width, height, path, dataPath);
            UserFonts.Add(name, font);
            return font;
        }

        public static Font UserFont(string name)
        {
            return UserFonts[name];
        }

        #endregion
    }
}