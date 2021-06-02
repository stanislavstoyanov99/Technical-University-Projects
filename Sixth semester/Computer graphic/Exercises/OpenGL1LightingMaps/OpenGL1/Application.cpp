#include "Application.h"

#include <iostream>
#include <glad/glad.h>
#include <GLFW/glfw3.h>

#include "Shader.h"
#include "VertexArray.h"
#include "VertexBuffer.h"

#include <glm/glm.hpp>
#include <glm/gtc/matrix_transform.hpp>

void framebuffer_size_callback(GLFWwindow* window, int width, int height)
{
    glViewport(0, 0, width, height);
}

void mouse_callback(GLFWwindow* window, double xpos, double ypos)
{
    static bool firstMouse = true;
    static double lastX;
	static double lastY;
	
    if (firstMouse)
    {
        lastX = xpos;
        lastY = ypos;
        firstMouse = false;
    }

    float xoffset = xpos - lastX;
    float yoffset = lastY - ypos;
    lastX = xpos;
    lastY = ypos;

    int state = glfwGetMouseButton(window, GLFW_MOUSE_BUTTON_LEFT);

    if (state != GLFW_PRESS)
        return;

    float sensitivity = 0.1f;
    xoffset *= sensitivity;
    yoffset *= sensitivity;

    auto* app = (Application*)glfwGetWindowUserPointer(window);

    app->_yaw += xoffset;
    app->_pitch += yoffset;

    if (app->_pitch > 89.0f)
        app->_pitch = 89.0f;
	
    if (app->_pitch < -89.0f)
        app->_pitch = -89.0f;

    glm::vec3 direction;
    direction.x = cos(glm::radians(app->_yaw)) * cos(glm::radians(app->_pitch));
    direction.y = sin(glm::radians(app->_pitch));
    direction.z = sin(glm::radians(app->_yaw)) * cos(glm::radians(app->_pitch));

    app->_cameraFront = glm::normalize(direction);
}

void scroll_callback(GLFWwindow* window, double xoffset, double yoffset)
{
    auto* app = (Application*)glfwGetWindowUserPointer(window);
	
    app->_fov -= (float)yoffset;
	
    if (app->_fov < 1.0f)
        app->_fov = 1.0f;
	
    if (app->_fov > 45.0f)
        app->_fov = 45.0f;
}

void Application::ProcessInput(GLFWwindow* window, float dt)
{
    const float cameraSpeed = 2.5f * dt; // adjust accordingly
	
    if (glfwGetKey(window, GLFW_KEY_W) == GLFW_PRESS)
        _cameraPos += cameraSpeed * _cameraFront;
    if (glfwGetKey(window, GLFW_KEY_S) == GLFW_PRESS)
        _cameraPos -= cameraSpeed * _cameraFront;
    if (glfwGetKey(window, GLFW_KEY_A) == GLFW_PRESS)
        _cameraPos -= glm::normalize(glm::cross(_cameraFront, _cameraUp)) * cameraSpeed;
    if (glfwGetKey(window, GLFW_KEY_D) == GLFW_PRESS)
        _cameraPos += glm::normalize(glm::cross(_cameraFront, _cameraUp)) * cameraSpeed;
}

void Application::Run()
{
    GLFWwindow* window;

    /* Initialize the glfw */
    if (!glfwInit())
        return;

    /* Create a windowed mode window and its OpenGL context */
    window = glfwCreateWindow(640, 480, "Hello World", NULL, NULL);

    if (!window)
    {
        glfwTerminate();
        return;
    }

    /* Make the window's context current */
    glfwMakeContextCurrent(window);

    if (!gladLoadGLLoader((GLADloadproc)glfwGetProcAddress))
    {
        std::cout << "Failed to initialize GLAD" << std::endl;
        return;
    }

    glViewport(0, 0, 640, 480);

    glfwSetWindowUserPointer(window, this);

    glfwSetFramebufferSizeCallback(window, framebuffer_size_callback);
    glfwSetCursorPosCallback(window, mouse_callback);
    glfwSetScrollCallback(window, scroll_callback);

    Init();

    float deltaTime = 0.0f;	// Time between current frame and last frame
    float lastFrame = 0.0f; // Time of last frame
	
	while (!glfwWindowShouldClose(window))
	{
        float currentFrame = glfwGetTime();
        deltaTime = currentFrame - lastFrame;
        lastFrame = currentFrame;
		
        ProcessInput(window, deltaTime);
        Update(deltaTime);
        Render();

        glfwSwapBuffers(window);
        glfwPollEvents();
	}

    glfwTerminate();
}

void Application::Init()
{
    float vertices[] = {
        // positions          // normals           // texture coords
        -0.5f, -0.5f, -0.5f,  0.0f,  0.0f, -1.0f,  0.0f, 0.0f,
         0.5f, -0.5f, -0.5f,  0.0f,  0.0f, -1.0f,  1.0f, 0.0f,
         0.5f,  0.5f, -0.5f,  0.0f,  0.0f, -1.0f,  1.0f, 1.0f,
         0.5f,  0.5f, -0.5f,  0.0f,  0.0f, -1.0f,  1.0f, 1.0f,
        -0.5f,  0.5f, -0.5f,  0.0f,  0.0f, -1.0f,  0.0f, 1.0f,
        -0.5f, -0.5f, -0.5f,  0.0f,  0.0f, -1.0f,  0.0f, 0.0f,

        -0.5f, -0.5f,  0.5f,  0.0f,  0.0f, 1.0f,   0.0f, 0.0f,
         0.5f, -0.5f,  0.5f,  0.0f,  0.0f, 1.0f,   1.0f, 0.0f,
         0.5f,  0.5f,  0.5f,  0.0f,  0.0f, 1.0f,   1.0f, 1.0f,
         0.5f,  0.5f,  0.5f,  0.0f,  0.0f, 1.0f,   1.0f, 1.0f,
        -0.5f,  0.5f,  0.5f,  0.0f,  0.0f, 1.0f,   0.0f, 1.0f,
        -0.5f, -0.5f,  0.5f,  0.0f,  0.0f, 1.0f,   0.0f, 0.0f,

        -0.5f,  0.5f,  0.5f, -1.0f,  0.0f,  0.0f,  1.0f, 0.0f,
        -0.5f,  0.5f, -0.5f, -1.0f,  0.0f,  0.0f,  1.0f, 1.0f,
        -0.5f, -0.5f, -0.5f, -1.0f,  0.0f,  0.0f,  0.0f, 1.0f,
        -0.5f, -0.5f, -0.5f, -1.0f,  0.0f,  0.0f,  0.0f, 1.0f,
        -0.5f, -0.5f,  0.5f, -1.0f,  0.0f,  0.0f,  0.0f, 0.0f,
        -0.5f,  0.5f,  0.5f, -1.0f,  0.0f,  0.0f,  1.0f, 0.0f,

         0.5f,  0.5f,  0.5f,  1.0f,  0.0f,  0.0f,  1.0f, 0.0f,
         0.5f,  0.5f, -0.5f,  1.0f,  0.0f,  0.0f,  1.0f, 1.0f,
         0.5f, -0.5f, -0.5f,  1.0f,  0.0f,  0.0f,  0.0f, 1.0f,
         0.5f, -0.5f, -0.5f,  1.0f,  0.0f,  0.0f,  0.0f, 1.0f,
         0.5f, -0.5f,  0.5f,  1.0f,  0.0f,  0.0f,  0.0f, 0.0f,
         0.5f,  0.5f,  0.5f,  1.0f,  0.0f,  0.0f,  1.0f, 0.0f,

        -0.5f, -0.5f, -0.5f,  0.0f, -1.0f,  0.0f,  0.0f, 1.0f,
         0.5f, -0.5f, -0.5f,  0.0f, -1.0f,  0.0f,  1.0f, 1.0f,
         0.5f, -0.5f,  0.5f,  0.0f, -1.0f,  0.0f,  1.0f, 0.0f,
         0.5f, -0.5f,  0.5f,  0.0f, -1.0f,  0.0f,  1.0f, 0.0f,
        -0.5f, -0.5f,  0.5f,  0.0f, -1.0f,  0.0f,  0.0f, 0.0f,
        -0.5f, -0.5f, -0.5f,  0.0f, -1.0f,  0.0f,  0.0f, 1.0f,

        -0.5f,  0.5f, -0.5f,  0.0f,  1.0f,  0.0f,  0.0f, 1.0f,
         0.5f,  0.5f, -0.5f,  0.0f,  1.0f,  0.0f,  1.0f, 1.0f,
         0.5f,  0.5f,  0.5f,  0.0f,  1.0f,  0.0f,  1.0f, 0.0f,
         0.5f,  0.5f,  0.5f,  0.0f,  1.0f,  0.0f,  1.0f, 0.0f,
        -0.5f,  0.5f,  0.5f,  0.0f,  1.0f,  0.0f,  0.0f, 0.0f,
        -0.5f,  0.5f, -0.5f,  0.0f,  1.0f,  0.0f,  0.0f, 1.0f
    };

    std::unique_ptr<VertexBuffer> vbo(new VertexBuffer(vertices, sizeof(vertices)));

    vbo->Bind();

    vbo->SetLayout(
        {
            {"aPos", Float3},
            {"aNorm", Float3},
            {"aTexCoords", Float2}
        }
    );

    _va = std::make_unique<VertexArray>();
    _va->SetVertexBuffer(std::move(vbo));
    _va->Bind();

    _shader = std::make_unique<Shader>("res\\lighting.vert.glsl", "res\\lighting.frag.glsl");
    _lightCubeShader = std::make_unique<Shader>("res\\light_cube.vert.glsl", "res\\light_cube.frag.glsl");

    _diffuseTexture = std::make_unique<Texture>("res\\container2.png");
    _specularTexture = std::make_unique<Texture>("res\\container2_specular.png");
    
    glEnable(GL_DEPTH_TEST);
}

void Application::Update(float dt)
{
    const auto view = glm::lookAt(_cameraPos, _cameraPos + _cameraFront, _cameraUp);
    const auto projection = glm::perspective(glm::radians(_fov), 800.0f / 600.0f, 0.1f, 100.0f);

    _shader->use();
    _shader->setFloatMat4("view", view);
    _shader->setFloatMat4("projection", projection);

    _lightCubeShader->use();
    _lightCubeShader->setFloatMat4("view", view);
    _lightCubeShader->setFloatMat4("projection", projection);
}

void Application::Render()
{
    glClearColor(0.1f, 0.2f, 0.3f, 1.f);
    glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);
	
    _va->Bind();

    _shader->use();

    _shader->setFloat3("light.position", _lightPos);
    _shader->setFloat3("light.ambient", glm::vec3(0.2f, 0.2f, 0.2f));
    _shader->setFloat3("light.diffuse", glm::vec3(0.5f, 0.5f, 0.5f)); // darken diffuse light a bit
    _shader->setFloat3("light.specular", glm::vec3(1.0f, 1.0f, 1.0f));
    _shader->setFloat3("viewPos", _cameraPos);

    _diffuseTexture->Bind(0);
    _specularTexture->Bind(1);

    _shader->setInt("material.diffuse", 0);
    _shader->setInt("material.specular", 1);
    _shader->setFloat("material.shininess", 32.0f);

    glm::mat4 model = glm::mat4(1.0f);
    _shader->setFloatMat4("model", model);
    glDrawArrays(GL_TRIANGLES, 0, 36);

    _lightCubeShader->use();
    model = glm::mat4(1.0f);
    model = glm::translate(model, _lightPos);
    model = glm::scale(model, glm::vec3(0.2f));
    _lightCubeShader->setFloatMat4("model", model);
    glDrawArrays(GL_TRIANGLES, 0, 36);
}
