cmake_minimum_required(VERSION 3.5.0)
project(my_opengl_project VERSION 0.1.0)

find_package(assimp REQUIRED)

add_executable(my_opengl_project
    src/main.cpp
    src/glad.h
    src/glad.c
)

configure_file(configuration/root_directory.h.in configuration/root_directory.h)
include_directories(${CMAKE_BINARY_DIR}/configuration)
target_include_directories(my_opengl_project PRIVATE ${CMAKE_SOURCE_DIR}/glm-1.0.1)

target_link_libraries(my_opengl_project glfw assimp::assimp)

