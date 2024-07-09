#version 330 core

out vec4 FragColor;

in vec2 TexCoords;

uniform sampler2D texture1;

void main()
{
    vec4 texColor = texture(texture1, TexCoords);
    if(texColor.a < 0.1)
        discard;
    FragColor = texColor;   // IMPORTANT, SOMETIMES WE CAN SEE THE BORDER WITH COLOUR AS IT IS STARTING TO REPEAT THE NEXT TEXTURE COLOR WHICH WAS THE BOTOM TEXTURE PIXEL,
                            // IN ORDER TO NOT HAVE THIS PROBLEM IS AS EASY AS CHANGING THE glTexParameteri() to GL_CLAMP_TO_EDGE AND NOT TO REPEAT!
}