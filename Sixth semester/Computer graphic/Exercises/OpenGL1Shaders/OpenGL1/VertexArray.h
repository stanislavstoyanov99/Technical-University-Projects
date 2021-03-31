#pragma once

#include "VertexBuffer.h"

class VertexArray
{
public:
	VertexArray();

	void Bind();
	void UnBind();

	void SetVertexBuffer(VertexBuffer& vb);
private:
	unsigned int id;
};

