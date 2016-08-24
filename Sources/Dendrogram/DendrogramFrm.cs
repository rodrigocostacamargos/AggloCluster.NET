using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AggloCluster.Dendrogram
{
    public partial class DendrogramFrm : Form
    {
        public SharpCluster.Clusters hierarchicalClusters;

        Graphics drawarea;

        private Node<string> root; //raiz do dendrograma
        private int leaves; //folhas do dendrograma
        private int levels; //niveis do dendrograma
        private int heightPerLeaf; //altura por folha
        private int widthPerLevel; //largura por nivel nivel
        private int currentY;
        private const int margin = 25;


        private Node<string> Create(string contents)
        {
            return new Node<string>(contents);
        }

        private Node<string> Create(Node<string> child0, Node<string> child1)
        {
            return new Node<string>(child0, child1);
        }

        // conta o numero de folhas
        private int CountLeaves(Node<string> node)
        {
            List<Node<string>> children = node.GetChildren();
            if (children.Count == 0)
            {
                return 1;
            }

            Node<string> child0 = children.ElementAt(0);
            Node<string> child1 = children.ElementAt(1);

            return CountLeaves(child0) + CountLeaves(child1);
        }

        // conta os niveis
        private int CountLevels(Node<string> node)
        {
            List<Node<string>> children = node.GetChildren();
            if (children.Count == 0)
            {
                return 1;
            }

            Node<string> child0 = children.ElementAt(0);
            Node<string> child1 = children.ElementAt(1);

            return 1 + Math.Max(CountLevels(child0), CountLevels(child1));

        }


        public DendrogramFrm()
        {
            InitializeComponent();
            drawarea = drawingArea.CreateGraphics();
        }

        private Node<string> BuildDendrogram(SharpCluster.Cluster[] clusters)
        {
            Node<string> child0;
            Node<string> child1;

            if (clusters.Count() == 2 && clusters.ElementAt(0).QuantityOfSubClusters() == 0)
            {
                child0 = GetNodeFromCluster(clusters.ElementAt(0));
                child1 = GetNodeFromCluster(clusters.ElementAt(1));

                return Create(child0, child1);
            }

            if (clusters.Count() == 1 && clusters.ElementAt(0).QuantityOfSubClusters() == 2)
            {
                return BuildDendrogram(clusters.ElementAt(0).GetSubClusters());
            }

            if (clusters.Count() == 2 && clusters.ElementAt(0).QuantityOfSubClusters() == 2)
            {
                child0 = BuildDendrogram(clusters.ElementAt(0).GetSubClusters());

                if (clusters.ElementAt(1).QuantityOfSubClusters() == 2)
                {
                    child1 = BuildDendrogram(clusters.ElementAt(1).GetSubClusters());
                }
                else
                {
                    child1 = GetNodeFromCluster(clusters.ElementAt(1));
                }
                

                return Create(child0, child1);
            }


            return root;
   
        }


   
        private Node<string> GetNodeFromCluster(SharpCluster.Cluster cluster)
        {
            return Create("Cluster"+cluster.Id.ToString());
        }

        public void DrawDendrogram(PaintEventArgs e)
        {
            //root = Create(
            //    Create("3"),
            //    Create(
            //        Create("2"),
            //        Create("1")
            //    )
            //);

            if (hierarchicalClusters == null)
            {
                MessageBox.Show("There is no clustering for the dendrogram");
                return;
            }

            root = BuildDendrogram(hierarchicalClusters.GetClusters());

            leaves = CountLeaves(root); //conta o numero de folhas do dendrograma
            levels = CountLevels(root); // conta a quantidade de niveis do dentrograma

            heightPerLeaf = (Height - margin - margin) / leaves; // calcula a altura (eixo Y) do formulario e divide pela quantidade de folhas
            widthPerLevel = (Width - margin - margin) / levels;  // calcula a largura (eixo X) do formulario e divide pela quantidade de niveis

            currentY = 0;

            drawarea = e.Graphics;

            drawarea.TranslateTransform(margin, margin);
            draw(drawarea, root, 0);


        }

        private Point draw(Graphics g, Node<string> node, int y)
        {
            List<Node<string>> children = node.GetChildren();
            if (children.Count == 0)
            {
                int x = Width - widthPerLevel - 2 * margin;

                g.DrawString(node.GetContents(), new Font("Times New Roman", 8.0f), Brushes.Black, x + 8, currentY - 8);
                int resultX = x;
                int resultY = currentY;
                currentY += heightPerLeaf;
                return new Point(resultX, resultY);
            }

            if (children.Count >= 2)
            {
                Node<string> child0 = children.ElementAt(0);
                Node<string> child1 = children.ElementAt(1);
                Point p0 = draw(g, child0, y);
                Point p1 = draw(g, child1, y + heightPerLeaf);

                g.FillRectangle(Brushes.Black, p0.X - 2, p0.Y - 2, 4, 4);
                g.FillRectangle(Brushes.Black, p1.X - 2, p1.Y - 2, 4, 4);

                int dx = widthPerLevel;
                int vx = Math.Min(p0.X - dx, p1.X - dx);

                Pen blackPen = new Pen(Color.Black);
                g.DrawLine(blackPen, vx, p0.Y, p0.X, p0.Y);
                g.DrawLine(blackPen, vx, p1.Y, p1.X, p1.Y);
                g.DrawLine(blackPen, vx, p0.Y, vx, p1.Y);

                Point p = new Point(vx, p0.Y + (p1.Y - p0.Y) / 2);
                return p;
            }

            // Should never happen
            return new Point();
        }


        private void drawingArea_Paint(object sender, PaintEventArgs e)
        {
            DrawDendrogram(e);
        }
    }
}
