using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawShapes
{
    public partial class Form1 : Form
    {

        Circle circle;
        RectangleShape rectangle;
        HandleVirables variable;
        PolygonShape polygon;
        TriangleShape Triangle;
        
        Color c;
        
       int count;
        
        int loopCounter;
        
        List<Circle> circleList;
        
        List<RectangleShape> rectList;
       
        List<PolygonShape> polyList;
        
        List<HandleVirables> varList;
       
        List<TriangleShape> triangleList;
        
        string runCmd;
       
        Boolean drawCircle, drawRect, drawPolgon, drawTriangle, fill;
        
        String app;
        
        String[] letters;
        
        int setX, setY;
        
        int thickness;
        
        Shape circleShape, recShape, polyShape, triangleShapes;

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                inputTextBox.Text = File.ReadAllText(openFileDialog1.FileName);
            }

        }

        private void saveShapeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, inputTextBox.Text);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            circle = new Circle(); 
            rectangle = new RectangleShape(); 
            circleList = new List<Circle>(); 
            rectList = new List<RectangleShape>(); 
            varList = new List<HandleVirables>();
            triangleList = new List<TriangleShape>();
            polyList = new List<PolygonShape>();
            c = Color.Red;
        }

        private void commandtextBox_TextChanged(object sender, EventArgs e)

        {
           //hold the value from text area
            runCmd = commandtextBox.Text.ToString().ToLower();
        }

        private void cmdExecuteBtn_Click(object sender, EventArgs e)
        {
            switch (runCmd)
            {

                case "clear"://if action command is clear
                    circleList.Clear();
                    rectList.Clear();
                    varList.Clear();
                    fill = false;
                    drawTriangle = false;
                    drawCircle = false;
                    drawRect = false;
                    drawPolgon = false;
                    inputTextBox.Clear();
                    commandtextBox.Clear();
                    pictureBox1.Refresh();
                    break;
                case "run":
                    //checks if command code is empty when clicked action button
                    if (inputTextBox.Text == "")
                    {
                        MessageBox.Show("No Syntax and Paramater Detected");
                    }
                    try
                    {
                        //Cnversts all the written command to lower case
                        app = inputTextBox.Text.ToLower();
                        //delimeters HandleVirables holds the array \r \n
                        char[] delimiters = new char[] { '\r', '\n' };
                        //holds invididuals code line 
                        string[] parts = app.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                        //loop through the whole app code line
                        for (int i = 0; i < parts.Length; i++)
                        {
                            //single code line
                            String code_line = parts[i];
                            //splits the code when space 
                            char[] value_code = new char[] { ' ' };
                            //holds invididuals code line
                            letters = code_line.Split(value_code, StringSplitOptions.RemoveEmptyEntries);

                            //calculation to add value to variable
                            if (Regex.IsMatch(letters[0], @"^[a-zA-Z]+$") && letters[1].Equals("+"))
                            {
                                //sets new incremented value to the defined variable and puts it in vaiableObjects class
                                varList[varList.FindIndex(x => x.variable.Contains(letters[0]))].
                                    setValue(varList[varList.FindIndex(x => x.variable.Contains(letters[0]))]
                                    .getValue() + Convert.ToInt32(letters[2]));
                            }
                            if ((Regex.IsMatch(letters[0], @"^[a-zA-Z]+$") && letters[1].Equals("=")))
                            {
                                if (varList.Exists(x => x.variable == letters[0] && x.value == Convert.ToInt32(letters[2])) == true)
                                {
                                    Console.WriteLine("variable exists: ");

                                }
                                //add new var if variableObject is empty
                                else if (varList == null || varList.Count == 0)
                                {
                                    variable = new HandleVirables();
                                    variable.setVariable(letters[0]);
                                    variable.setValue(Convert.ToInt32(letters[2]));
                                    varList.Add(variable);
                                }
                                else
                                {
                                    //else checks if variable exists or not
                                    if (!varList.Exists(x => x.variable == letters[0]))
                                    {
                                        variable = new HandleVirables();
                                        variable.setVariable(letters[0]);
                                        variable.setValue(Convert.ToInt32(letters[2]));
                                        varList.Add(variable);
                                    }
                                    //else add new variable value to var
                                    else
                                    {
                                        variable = new HandleVirables();
                                        variable.setVariable(letters[0]);
                                        variable.setValue(Convert.ToInt32(letters[2]));
                                        varList[varList.FindIndex(x => x.variable.Contains(letters[0]))] = variable;
                                    }
                                }
                            }

                            //checks if letters has 'move' command then
                            if (letters[0] == "shift")
                            {
                                setX = Convert.ToInt32(letters[1]);//sets the location the shape xaxis
                                setY = Convert.ToInt32(letters[2]);//sets the location of the shape yaxis
                            }



                            //checks if the word holds the value 'draw' then
                            if (letters[0].Equals("draw"))
                            {
                                count += 1;//value to increment draw circle method
                                if (letters[1].Equals("rectangle"))
                                {
                                    //checks if the given paramater is wrng then draws message
                                    if (!(letters.Length == 4))
                                    {
                                        MessageBox.Show("!!!Wrong Command!!!\neg.draw rectangle 100 100 ");
                                    }

                                    else
                                    {
                                        if (varList.Exists(x => x.variable == letters[2] == true))
                                        {
                                            letters[2] = Convert.ToString(varList.ElementAt(varList.
                                                FindIndex(x => x.variable.Contains(letters[2]))).getValue()); //variable value to height parameter
                                        }
                                        if (varList.Exists(x => x.variable == letters[3]) == true)
                                        {
                                            letters[3] = Convert.ToString(varList.ElementAt(varList.
                                                FindIndex(x => x.variable.Contains(letters[3]))).getValue()); //variable value to width parameter
                                        }

                                        if (rectList.Exists(x => x.getX() == setX && x.getY() == setY
                                        && x.getHeight() == Convert.ToInt32(letters[2]) && x.getWidth() ==
                                        Convert.ToInt32(letters[3])) == true)//checks if rectangle with x,y,height,width parameter exists or not
                                        {
                                            Console.WriteLine("!!rectangle object exists with given parameters!!");
                                        }
                                        else
                                        {
                                            RectangleShape rects = new RectangleShape();
                                            rects.setX(setX);
                                            rects.setY(setY);
                                            rects.setHeight(Convert.ToInt32(letters[2]));
                                            rects.setWidth(Convert.ToInt32(letters[3]));
                                            rectList.Add(rects);
                                            drawRect = true;
                                        }
                                    }
                                }

                                if (letters[1] == "triangle")
                                {
                                    //drawd Triangle instance of Triangle class
                                    TriangleShape Triangle = new TriangleShape();
                                    //Takes the cordination of the Triangle
                                    PointF[] points = { new PointF(100, 100), new PointF(200, 100), new PointF(150, 10) };
                                    //puts points value to Triangle setter method
                                    Triangle.setPoints(points);
                                    triangleList.Add(Triangle);
                                    //makes draw Triangle true
                                    drawTriangle = true;
                                }
                                //checks for 'circle' word
                                if (letters[1] == "circle")
                                {

                                    //checks weather the written code is right or wrong
                                    if (!(letters.Length == 3))
                                    {
                                        MessageBox.Show("!!!Wrong Command!!!\neg.draw circle 100");
                                    }
                                    if (varList.Exists(x => x.variable == letters[2]) == true)
                                    //assigns variable value to draw code parameter value
                                    {
                                        letters[2] = Convert.ToString(varList.ElementAt(varList.
                                            FindIndex(x => x.variable.Contains(letters[2]))).getValue()); //variable value to radius parameter
                                    }

                                    if (circleList.Exists(x => x.getX() == setX && x.getY() == setY
                                && x.getRadius() == Convert.ToInt32(letters[2])) == true)
                                    //checks if circle with x,y,radius parameter exists or not
                                    {
                                        Console.WriteLine("circle object exists with given parameters");
                                    }

                                    else
                                    {
                                        Circle circle = new Circle();
                                        circle.setX(setX);
                                        circle.setY(setY);
                                        circle.setRadius(Convert.ToInt32(letters[2]));
                                        circleList.Add(circle);
                                        drawCircle = true;
                                    }
                                }
                                //checks if the word is rectangle or not
                                if (letters[1].Equals("polygon"))
                                {
                                    //drawd poly instace of Polygon class
                                    PolygonShape polygon = new PolygonShape();
                                    //stores the points in array PointF
                                    PointF[] points = {
                                        new PointF(50.0F, 50.0F),
                                        new PointF(70.0F, 25.0F),
                                        new PointF(100.0F, 5.0F),
                                        new PointF(150.0F, 30.0F),
                                        new PointF(200.0F, 50.0F),
                                        new PointF(250.0F, 100.0F),
                                        new PointF(150.0F, 150.0F)
                                    };
                                    //adds the value of points in the Polygon setter method
                                    polygon.setPoints(points);
                                    polyList.Add(polygon);
                                    drawPolgon = true;
                                }
                            }

                            //checks if the word holds the value 'if' then   
                            if (letters[0] == "if") //code for if statement
                            {
                                //decleared the variable_nanme as string and stored the value of 'word[1]'
                                string variable_name = letters[1];
                                //decleared value as an integer and stored the value of word[3]
                                int value = Convert.ToInt32(letters[3]);
                                if (varList.Exists(x => x.variable == letters[1]) == true
                                    && varList.Exists(x => x.value == Convert.ToInt32(letters[3])) == true)
                                //checks if condition defined in if condition matches with variable objects list
                                {
                                    Console.WriteLine("Entered into if statement");
                                }
                                else
                                {//directed to end if line
                                    i = Array.IndexOf(parts, "end if");
                                }

                            }

                            //checks if the word holds the value 'loop' then
                            if (letters[0] == "loop") //code for loop statement
                            {
                                loopCounter = Convert.ToInt32(letters[1]); //defines loop count variable
                            }

                            //checks if the word holds the value 'end loop' then
                            if (parts[i] == "end loop") // code for end loop statement
                            {
                                if (count < loopCounter) //if count to draw is not less than loop count
                                {
                                    i = Array.IndexOf(parts, "loop " + loopCounter);
                                }
                                else // keep drawing
                                {
                                    i = Array.IndexOf(parts, "end loop");
                                }
                            }
                            //checks if word holds the value 'color' then
                            if (letters[0] == "color")
                            {
                                thickness = Convert.ToInt32(letters[2]);//converting string value to integer value

                                if (letters[1] == "red")//if red then color changes to red
                                {
                                    c = Color.Red;
                                }
                                else if (letters[1] == "blue")//if blue then color changes to blue
                                {
                                    c = Color.Blue;
                                }
                                else if (letters[1] == "yellow")//if yellow then color changes to yellow
                                {
                                    c = Color.Yellow;
                                }
                                else
                                {
                                    c = Color.Red;//default color
                                }
                            }

                            //checks if the word holds the value 'fill' then
                            if (letters[0] == "fill")
                            {
                                if (letters[1] == "on")//checks if the word[1] holds value'on'
                                {
                                    fill = true;//sets fill ture
                                }
                                if (letters[1] == "off")//checks if the word[1] holds value 'off'
                                {
                                    fill = false;//sets fill false
                                }
                            }
                        }
                    }
                    catch (IndexOutOfRangeException ex)
                    {
                        Console.WriteLine("Error" + " " + ex);
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("Enter the correct parameter" + " " + ex);

                    }
                    catch (ArgumentOutOfRangeException ex)
                    {
                        Console.WriteLine("Enter the correct parameter" + " " + ex);
                    }
                    //refresh everytime drawing equals to true
                    pictureBox1.Refresh();
                    break;
                default://if acction text area is empty
                    MessageBox.Show("The action command is empty\n" +
                        "Or\n" +
                        "Must be: 'Run' for Execuit the app\n" +
                        "Must be: 'Clear' for Fresh Start");
                    break;
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("How to Draw Shapes:\n" +

              "To draw Shapes Shape Drawing Command have to Enter in the Command Box \n" + "" +
              "For Example \n" +
              "Write Draw Circle 200 and Write run in command box and hit Draw it will draw Circle Shape \n"+
              "For Ploygon write 'draw ploygon' and it will draw polygon Shape \n" +
              "For Rectangle Write 'draw rectangle 100 200' it will draw Rectangle Shape \n"+
              "For Trianlge write 'draw triangle"

              );

        }

        public Form1()
        {
            InitializeComponent();
            AbstractShape shapeFactory = ShapeFactory.getFactory("shape");
            circleShape = shapeFactory.getShape("Circle");
             recShape = shapeFactory.getShape("Rectangle");
            polyShape = shapeFactory.getShape("Polygon");
            triangleShapes = shapeFactory.getShape("Triangle");
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            

        }
    }
}
