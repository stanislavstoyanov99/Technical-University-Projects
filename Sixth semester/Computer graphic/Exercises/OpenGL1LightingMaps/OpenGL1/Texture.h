#pragma once

#include <string>

class Texture
{
public:
	Texture(const std::string& fileName);

	void Bind(unsigned textureSlot = 0);
	
	int GetWidth() const { return _width; }
	int GetHeight() const { return _height; }

private:
	unsigned _texture;

	int _width = 0;
	int _height = 0;
};

