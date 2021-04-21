#include <glad/glad.h>
#include <GLFW/glfw3.h>
#include <glm/glm.hpp>
#include <glm/gtc/matrix_transform.hpp>
#include <stb_image/stb_image.h>
#include <iostream>

#include "Application.h"
#include "Shader.h"
#include "VertexArray.h"
#include "VertexBuffer.h"

void framebuffer_size_callback(GLFWwindow* window, int width, int height)
{
	glViewport(0, 0, width, height);
}

void Application::Run()
{
	/* Initialize the library */
	if (!glfwInit())
		return;

	glfwWindowHint(GLFW_CONTEXT_VERSION_MAJOR, 4);
	glfwWindowHint(GLFW_CONTEXT_VERSION_MINOR, 6);
	glfwWindowHint(GLFW_OPENGL_PROFILE, GLFW_OPENGL_CORE_PROFILE);

	/* Create a windowed mode window and its OpenGL context */
	GLFWwindow* window = glfwCreateWindow(640, 480, "Hello World", nullptr, nullptr);
	if (!window)
	{
		glfwTerminate();
		return;
	}

	/* Make the window's context current */
	glfwMakeContextCurrent(window);

	// Loads all gl functions from graphic driver
	if (!gladLoadGLLoader((GLADloadproc)glfwGetProcAddress))
	{
		std::cout << "Failed to initialize GLAD" << std::endl;
		return;
	}

	glViewport(0, 0, 640, 480);
	glfwSetFramebufferSizeCallback(window, framebuffer_size_callback);

	Init();

	while(!glfwWindowShouldClose(window))
	{
		Update();
		Render();

		/* Swap front and back buffers */
		glfwSwapBuffers(window);

		/* Poll for and process events */
		glfwPollEvents();
	}

	glfwTerminate();
}

void Application::Init()
{
	float vertices[] = {
		// positions          // colors           // texture coords
		 0.5f,  0.5f, 0.0f,   1.0f, 0.0f, 0.0f,   1.0f, 1.0f,   // top right
		 0.5f, -0.5f, 0.0f,   0.0f, 1.0f, 0.0f,   1.0f, 0.0f,   // bottom right
		-0.5f, -0.5f, 0.0f,   0.0f, 0.0f, 1.0f,   0.0f, 0.0f,   // bottom left
		-0.5f,  0.5f, 0.0f,   1.0f, 1.0f, 0.0f,   0.0f, 1.0f    // top left 
	};

	unsigned int indices[] =
	{	// note that we start from 0!
		0, 1, 3,   // first triangle
		1, 2, 3    // second triangle
	};

	// Create Vertex buffer with unique pointer
	std::unique_ptr<VertexBuffer> vbo(new VertexBuffer(vertices, sizeof(vertices)));

	vbo->Bind();
	vbo->SetLayout(
		{
			{ "aPos", Float3 },
			{ "aColor", Float3 },
			{ "aTexCoord", Float2 }
		});
	
	// Create Index buffer object
	auto ibo = std::make_unique<IndexBuffer>(indices, sizeof(indices));
	
	// Create Vertex array object and set vertex buffer
	_va = std::make_unique<VertexArray>();
	
	_va->SetVertexBuffer(std::move(vbo));
	_va->SetIndexBuffer(std::move(ibo));
	_va->Bind();

	_shader = std::make_unique<Shader>("res\\vertex.glsl", "res\\fragment.glsl");

	_texture = std::make_unique<Texture>("res\\container.jpg");
}

void Application::Update()
{
}

void Application::Render()
{
	glClearColor(0.1f, 0.2f, 0.3f, 1.f);
	glClear(GL_COLOR_BUFFER_BIT);
	
	glm::mat4 trans = glm::mat4(1.0f);
	trans = glm::translate(trans, glm::vec3(0.5f, -0.5f, 0.0f));
	trans = glm::rotate(trans, (float)glfwGetTime(), glm::vec3(0.0f, 0.0f, 1.0f));

	_shader->Use();
	_shader->SetInt("ourTexture", 0);
	_shader->SetFloatMat4("transform", trans);

	_va->Bind();

	_texture->Bind(0);

	//glDrawArrays(GL_TRIANGLES, 0, 3);
	glDrawElements(GL_TRIANGLES, 6, GL_UNSIGNED_INT, 0);
}
