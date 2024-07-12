#version 330 core

layout(location = 0) in vec4 vPosition;
layout(location = 1) in vec4 aTEX0;
layout(location = 2) in vec4 aTEX1;
layout(location = 3) in vec4 aTEX2;
layout(location = 4) in vec4 aTEX3;
layout(location = 5) in vec4 aTEX4;
layout(location = 6) in vec4 aTEX5;
layout(location = 7) in vec4 aTEX6;

out vec4 TEX0;
out vec4 TEX1;
out vec4 TEX2;
out vec4 TEX3;
out vec4 TEX4;
out vec4 TEX5;
out vec4 TEX6;

void main()
{
    gl_Position = vPosition;
    TEX0 = aTEX0;
    TEX1 = aTEX1;
    TEX2 = aTEX2;
    TEX3 = aTEX3;
    TEX4 = aTEX4;
    TEX5 = aTEX5;
    TEX6 = aTEX6;
}
