#pragma once

#include <memory>
#include "Shader.h"
#include "VertexArray.h"
#include <glm/glm.hpp>

#include "Model.h"

struct GLFWwindow;

class Application
{
public:
	void Run();

private:
	void Init();
	void Update(float dt);
	void Render();

	void ProcessInput(GLFWwindow* window, float dt);

	friend void mouse_callback(GLFWwindow* window, double xpos, double ypos);
	friend void scroll_callback(GLFWwindow* window, double xoffset, double yoffset);

private:
	std::unique_ptr<VertexArray> _va;
	std::unique_ptr<Shader> _shader;
	std::unique_ptr<Shader> _lightCubeShader;

	std::unique_ptr<Model> _backpack;

	glm::vec3 _lightPos = glm::vec3(1.2f, 1.0f, 2.0f);
	glm::vec3 _lightColor = glm::vec3(1.f, 1.f, 1.f);

	glm::vec3 _cameraPos = glm::vec3(0.0f, 0.0f, 3.0f);
	glm::vec3 _cameraFront = glm::vec3(0.0f, 0.0f, -1.0f);
	glm::vec3 _cameraUp = glm::vec3(0.0f, 1.0f, 0.0f);

	float _yaw = -90.0f;
	float _pitch = 0.0f;
	float _fov = 45.f;
};
