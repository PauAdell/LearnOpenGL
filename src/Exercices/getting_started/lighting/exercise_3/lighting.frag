#version 330 core

in vec3 GouraudLighting;

out vec4 FragColor;

uniform vec3 objectColor;

void main()
{

    vec3 result = GouraudLighting * objectColor;
    FragColor = vec4(result, 1.0);
}
