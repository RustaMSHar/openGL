namespace openGL
{
    public partial class Form1 : Form
    {

        private float axis_rotate_X;
        private float axis_rotate_Y;
        private float axis_rotate_Z;

        private float axis_scale = -5.0f;
        


        public Form1()
        {
            InitializeComponent();

            this.axis_rotate_X = 0;
            this.axis_rotate_Y = 0;
            this.axis_rotate_Z = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.axis_rotate_X = this.axis_rotate_X + 5f;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.axis_rotate_X = this.axis_rotate_X - 5f;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.axis_rotate_Y = this.axis_rotate_Y + 5f;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.axis_rotate_Y = this.axis_rotate_Y - 5f;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.axis_rotate_Z = this.axis_rotate_Z + 5f;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.axis_rotate_Z = this.axis_rotate_Z - 5f;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.axis_scale = this.axis_scale + 1f;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.axis_scale = this.axis_scale - 1f;
        }

        private void openGlDraw(object sender, SharpGL.RenderEventArgs args)
        {

            SharpGL.OpenGL gl = this.openglControl1.OpenGL;

            gl.Clear(SharpGL.OpenGL.GL_COLOR_BUFFER_BIT | SharpGL.OpenGL.GL_DEPTH_BUFFER_BIT);

            gl.LoadIdentity();

           

            gl.Translate(0.0f, 0.0f, axis_scale);
            

            gl.Rotate(axis_rotate_X, 1.0f, 0.0f, 0.0f); //Rotate X 
            gl.Rotate(axis_rotate_Y, 0.0f, 1.0f, 0.0f); //Rotate Y
            gl.Rotate(axis_rotate_Z, 0.0f, 0.0f, 1.0f); //Rotate Z

            gl.Begin(SharpGL.OpenGL.GL_TRIANGLES);
            gl.Color(1.0f, 0.0f, 0.0f);
            gl.Vertex(0.0f, 1.0f, 0.0f);
            gl.Color(0.0f, 1.0f, 0.0f); 
            gl.Vertex(-1.0f, -1.0f, 1.0f);
            gl.Color(0.0f, 0.0f, 1.0f);
            gl.Vertex(1.0f, -1.0f, 1.0f);


            gl.Color(1.0f, 0.0f, 0.0f);
            gl.Vertex(0.0f, 1.0f, 0.0f);
            gl.Color(0.0f, 0.0f, 1.0f);
            gl.Vertex(1.0f, -1.0f, 1.0f);
            gl.Color(0.0f, 1.0f, 0.0f);
            gl.Vertex(1.0f, -1.0f, -1.0f);



            gl.Color(1.0f, 0.0f, 0.0f);
            gl.Vertex(0.0f, 1.0f, 0.0f);
            gl.Color(0.0f, 1.0f, 0.0f);
            gl.Vertex(1.0f, -1.0f, -1.0f);
            gl.Color(0.0f, 0.0f, 1.0f);
            gl.Vertex(-1.0f, -1.0f, -1.0f);

            gl.Color(1.0f, 0.0f, 0.0f);
            gl.Vertex(0.0f, 1.0f, 0.0f);
            gl.Color(0.0f, 0.0f, 1.0f);
            gl.Vertex(-1.0f, -1.0f, -1.0f);
            gl.Color(0.0f, 1.0f, 0.0f);
            gl.Vertex(-1.0f, -1.0f, 1.0f);


            gl.End();


            gl.LoadIdentity();

        }
    }
}