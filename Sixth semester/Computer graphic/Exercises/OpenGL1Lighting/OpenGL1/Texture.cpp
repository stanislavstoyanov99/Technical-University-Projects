#include "Texture.h"

#include <iostream>
#include <glad/glad.h>
#include <stb_image/stb_image.h>

Texture::Texture(const std::string& fileName)
{
    glGenTextures(1, &_texture);
	
    glBindTexture(GL_TEXTURE_2D, _texture);
	
    // set the texture wrapping/filtering options (on the currently bound texture object)
    glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_WRAP_S, GL_REPEAT);
    glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_WRAP_T, GL_REPEAT);
	
    glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MIN_FILTER, GL_LINEAR);
    glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MAG_FILTER, GL_LINEAR);
	
    // load and generate the texture
    int nrChannels;
    unsigned char* data = stbi_load(fileName.c_str(), &_width, &_height, &nrChannels, 0);
	
    if (data)
    {
        glTexImage2D(GL_TEXTURE_2D, 0, GL_RGB, _width, _height, 0, GL_RGB, GL_UNSIGNED_BYTE, data);
        glGenerateMipmap(GL_TEXTURE_2D);
    }
    else
    {
        std::cout << "Failed to load texture" << std::endl;
        return;
    }
	
    stbi_image_free(data);
}

void Texture::Bind(unsigned textureSlot)
{
    glActiveTexture(GL_TEXTURE0 + textureSlot);
    glBindTexture(GL_TEXTURE_2D, _texture);
}
