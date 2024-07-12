#version 330 core

out vec4 FragColor;

in vec4 TEX0;
in vec4 TEX1;
in vec4 TEX2;
in vec4 TEX3;
in vec4 TEX4;
in vec4 TEX5;
in vec4 TEX6;

uniform sampler2D texture1;

void main()
{
    vec4 textureColor = texture(texture1, TEX0.xy);
    textureColor.x += 1.0/256 * 100;
    FragColor = textureColor;
    //FragColor = vec4(1.0, 0.0, 0.0, 1.0);
}