#pragma once

class IndexBuffer
{
public:
	IndexBuffer(unsigned* data, int size);

	void Bind();
	void Unbind();

private:
	unsigned int id;
};