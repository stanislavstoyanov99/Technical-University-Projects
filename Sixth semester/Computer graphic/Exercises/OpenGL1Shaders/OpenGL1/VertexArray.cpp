#include "VertexArray.h"

#include <glad/glad.h>

VertexArray::VertexArray()
{
	glGenVertexArrays(1, &id);
}

void VertexArray::Bind()
{
	glBindVertexArray(id);
}

void VertexArray::UnBind()
{
	glBindVertexArray(0);
}

void VertexArray::SetVertexBuffer(VertexBuffer& vb)
{
	Bind();
	vb.Bind();

	const auto& layout = vb.GetLayout();
	auto i = 0;

	for (const auto& element : layout)
	{
		glVertexAttribPointer(i, GetComponentCount(element.type), GL_FLOAT, GL_FALSE, 6 * sizeof(float), (void*)0);
		glEnableVertexAttribArray(i);
		
		++i;
	}
}
