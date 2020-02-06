using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpGL;

namespace CUBORUBIK1
{
    class DibujoCubo
    {
        public void Dibujar(OpenGL gl)
        {

            //naranja
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(1.0f, 0.5f, 0.0);
            gl.Vertex(-3.0f, 3.0f, -3.0f); //1
            gl.Vertex(-3.0f, -3.0f, -3.0f);//37
            gl.Vertex(-3.0f, -3.0f, 3.0f);//40
            gl.Vertex(-3.0f, 3.0f, 3.0f);//4
            gl.End();

            //verde
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.0f, 1.0f, 0.0);
            gl.Vertex(-3.0f, 3.0f, 3.0f);//4
            gl.Vertex(-3.0f, -3.0f, 3.0f);//40
            gl.Vertex(3.0f, -3.0f, 3.0f);//43
            gl.Vertex(3.0f, 3.0f, 3.0f);//7
            gl.End();

            //rojo
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(1.0f, 0.0f, 0.0);
            gl.Vertex(3.0f, 3.0f, 3.0f);//7
            gl.Vertex(3.0f, -3.0f, 3.0f);//43
            gl.Vertex(3.0f, -3.0f, -3.0f);//46
            gl.Vertex(3.0f, 3.0f, -3.0f);//10
            gl.End();

            //azul
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.0f, 0.0f, 1.0);
            gl.Vertex(3.0f, 3.0f, -3.0f);//10
            gl.Vertex(3.0f, -3.0f, -3.0f);//46
            gl.Vertex(-3.0f, -3.0f, -3.0f);//37
            gl.Vertex(-3.0f, 3.0f, -3.0f); //1
            gl.End();

            //blanco
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(1.0f, 1.0f, 1.0);
            gl.Vertex(-3.0f, 3.0f, -3.0f); //1
            gl.Vertex(-3.0f, 3.0f, 3.0f);//4
            gl.Vertex(3.0f, 3.0f, 3.0f);//7
            gl.Vertex(3.0f, 3.0f, -3.0f);//10
            gl.End();

            //amarillo
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(1.0f, 1.0f, 0.0);
            gl.Vertex(-3.0f, -3.0f, -3.0f);//37
            gl.Vertex(-3.0f, -3.0f, 3.0f);//40
            gl.Vertex(3.0f, -3.0f, 3.0f);//43
            gl.Vertex(3.0f, -3.0f, -3.0f);//46
            gl.End();

            //negro
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.0f, 0.0f, 0.0);
            gl.Vertex(-3.1f, 3.1f, -1.1f); //2
            gl.Vertex(-3.1f, -3.1f, -1.1f);//38
            gl.Vertex(3.1f, -3.1f, -1.1f);//45
            gl.Vertex(3.1f, 3.1f, -1.1f);//9
            gl.End();

            //negro
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.0f, 0.0f, 0.0);
            gl.Vertex(-3.1f, 3.1f, 1.1f);//3
            gl.Vertex(-3.1f, -3.1f, 1.1f);//39
            gl.Vertex(3.1f, -3.1f, 1.1f);//44
            gl.Vertex(3.1f, 3.1f, 1.1f);//8
            gl.End();

            //negro
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.0f, 0.0f, 0.0);
            gl.Vertex(-1.1f, 3.1f, 3.1f);//5
            gl.Vertex(-1.1f, -3.1f, 3.1f);//41
            gl.Vertex(-1.1f, -3.1f, -3.1f);//48
            gl.Vertex(-1.1f, 3.1f, -3.1f);//12
            gl.End();

            //negro
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.0f, 0.0f, 0.0);
            gl.Vertex(1.1f, 3.1f, 3.1f);//6
            gl.Vertex(1.1f, -3.1f, 3.1f);//42
            gl.Vertex(1.1f, -3.1f, -3.1f);//47
            gl.Vertex(1.1f, 3.1f, -3.1f);//11
            gl.End();

            //negro
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.0f, 0.0f, 0.0);
            gl.Vertex(-3.1f, -1.1f, -3.1f);//25
            gl.Vertex(-3.1f, -1.1f, 3.1f);//28
            gl.Vertex(3.1f, -1.1f, 3.1f);//31
            gl.Vertex(3.1f, -1.1f, -3.1f);//34
            gl.End();

            //negro
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.0f, 0.0f, 0.0);
            gl.Vertex(-3.1f, 1.1f, -3.1f);//13
            gl.Vertex(-3.05f, 1.05f, 3.1f);//16
            gl.Vertex(3.1f, 1.1f, 3.1f);//19
            gl.Vertex(3.1f, 1.1f, -3.1f);//22
            gl.End();


        }
    }
}
