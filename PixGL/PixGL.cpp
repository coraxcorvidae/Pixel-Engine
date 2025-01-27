#include "PixGL.h"

PixGL void SetValues(float pw_, float ph_, float ww_, float wh_)
{
	pw = pw_;
	ph = ph_;
	ww = ww_;
	wh = wh_;
}

PixGL void CreateCoords(int pixW, int pixH, int scrW, int scrH)
{
	int winW = pixW * scrW;
	int winH = pixH * scrH;

	for (int i = 0; i < winW; i++)
	{
		for (int j = 0; j < winH; j++)
		{
			float x = i / (float)winW;
			x = x * 2 - 1;
			float y = j / (float)winH;
			y = y * 2 - 1;

			unitCoords.push_back({ x, y });
		}
	}

	for (int i = 0; i < scrW; i++)
	{
		for (int j = 0; j < scrH; j++)
		{
			Point p;
			p.x = i / (float)scrW;
			p.x = p.x * 2 - 1;
			p.y = j / (float)scrH;
			p.y = p.y * 2 - 1; 
			
			Point p2;
			p2.x = (i + 1) / (float)scrW;
			p2.x = p2.x * 2 - 1;
			p2.y = (j + 1) / (float)scrH;
			p2.y = p2.y * 2 - 1;

			coords.push_back(std::make_pair(p, p2));
		}
	}
}

PixGL void RenderUnitPixels(int width, int height, const Pixel* pixels)
{
	auto it = unitCoords.begin();

	glBegin(GL_POINTS);
	for (int i = 0; i < width; i++)
	{
		for (int j = 0; j < height; j++)
		{
			auto point = *it;
			advance(it, 1);

			Pixel p = pixels[j * width + i];
			
			glColor3ub(p.r, p.g, p.b);
			glVertex2f(point.x, -point.y);
		}
	}
	glEnd();
}

PixGL void RenderPixels(int width, int height, const Pixel* pixels)
{
	auto it = coords.begin();

	glBegin(GL_QUADS);
	for (int i = 0; i < width; i++)
	{
		for (int j = 0; j < height; j++)
		{
			Pixel p = pixels[j * width + i];
		
			auto point1 = (*it).first;
			auto point2 = (*it).second;
			
			std::advance(it, 1);

			glColor3ub(p.r, p.g, p.b);

			glVertex2f(point1.x, -point1.y);
			glVertex2f(point1.x, -point2.y);
			glVertex2f(point2.x, -point2.y);
			glVertex2f(point2.x, -point1.y);
		}
	}
	glEnd();
}

PixGL void RenderText(int scrW, int scrH, int width, int height, const Pixel* pixels)
{
	auto it = unitCoords.begin();

	glBegin(GL_POINTS);
	for (int i = 0; i < width; i++)
	{
		for (int j = 0; j < height; j++)
		{
			auto point = *it;
			advance(it, 1);

			Pixel p = pixels[j * width + i];

			if (p.a == 0)
				continue;

			glColor3ub(p.r, p.g, p.b);
			glVertex2f(point.x, -point.y);
		}

		if (scrH > height)
			advance(it, scrH - height);
	}
	glEnd();
}

PixGL void DestroyCoords()
{
	coords.clear();
	unitCoords.clear();
}