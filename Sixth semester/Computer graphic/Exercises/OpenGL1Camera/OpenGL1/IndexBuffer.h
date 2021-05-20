#pragma once

class IndexBuffer
{
public:
	IndexBuffer(unsigned* data, int size);

	void Bind();
	void UnBind();
private:
	unsigned int id;
};

