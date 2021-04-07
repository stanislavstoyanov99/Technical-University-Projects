#pragma once

#include <memory>

#include "Shader.h"
#include "VertexArray.h"

class Application
{
public:
	void Run();

private:
	void Init();
	void Update();
	void Render();

private:
	std::unique_ptr<VertexArray> _va;
	std::unique_ptr<Shader> _shader;
};

