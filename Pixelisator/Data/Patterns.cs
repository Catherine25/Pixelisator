using System.Drawing;

namespace Pixelisator.Data
{
    static class Patterns
    {
        //data
        static Patterns()
        {
            //Progress.Counter = 0;
        }
        static Color curPixel = Color.Transparent,
            upPixel = Color.Transparent,
            rightPixel = Color.Transparent,
            downPixel = Color.Transparent,
            leftPixel = Color.Transparent,
            upRightPixel = Color.Transparent,
            rightDownPixel = Color.Transparent,
            downLeftPixel = Color.Transparent,
            leftUpPixel = Color.Transparent;
        static public Bitmap Bitmap { get; set; }
        static public event System.Action ChangedOnce;

        static public void ImageToBitmap(Image image) => Bitmap = (Bitmap)image;

        //- -- -+- -- - Drawing Patterns - -- -+- -- -
        public static void PlusEdit()
        {
            for (int x = 1; x < Bitmap.Width - 2; x++)
            {
                for (int y = 1; y < Bitmap.Height - 2; y++)
                {
                    //store pixels
                    curPixel = Bitmap.GetPixel(x, y);
                    upPixel = Bitmap.GetPixel(x, y - 1);
                    downPixel = Bitmap.GetPixel(x, y + 1);
                    rightPixel = Bitmap.GetPixel(x + 1, y);
                    leftPixel = Bitmap.GetPixel(x - 1, y);

                    //comparing
                    if (upPixel.Equals(rightPixel))
                        if (upPixel.Equals(leftPixel))
                            if (upPixel.Equals(downPixel))
                                if (!upPixel.Equals(curPixel))
                                {
                                    Bitmap.SetPixel(x, y, upPixel);
                                    Progress.Counter++;
                                    continue;
                                }
                }
            }
            ChangedOnce();
        }

        public static void TriangleEdit()
        {
            for (int x = 1; x < Bitmap.Width - 2; x++)
            {
                for (int y = 1; y < Bitmap.Height - 2; y++)
                {
                    //store pixels
                    curPixel = Bitmap.GetPixel(x, y);
                    upPixel = Bitmap.GetPixel(x, y - 1);
                    downPixel = Bitmap.GetPixel(x, y + 1);
                    rightPixel = Bitmap.GetPixel(x + 1, y);
                    leftPixel = Bitmap.GetPixel(x - 1, y);

                    //up-oriented comparing
                    if (upPixel.Equals(rightPixel))
                        if (upPixel.Equals(leftPixel))
                            if (!upPixel.Equals(curPixel))
                            {
                                Bitmap.SetPixel(x, y, upPixel);
                                Progress.Counter++;
                                continue;
                            }

                    //right-oriented comparing
                    if (rightPixel.Equals(upPixel))
                        if (rightPixel.Equals(downPixel))
                            if (!rightPixel.Equals(curPixel))
                            {
                                Bitmap.SetPixel(x, y, rightPixel);
                                Progress.Counter++;
                                continue;
                            }

                    //down-oriented comparing
                    if (downPixel.Equals(rightPixel))
                        if (downPixel.Equals(leftPixel))
                            if (!downPixel.Equals(curPixel))
                            {
                                Bitmap.SetPixel(x, y, downPixel);
                                Progress.Counter++;
                                continue;
                            }

                    //left-oriented comparing
                    if (leftPixel.Equals(upPixel))
                        if (leftPixel.Equals(downPixel))
                            if (!leftPixel.Equals(curPixel))
                            {
                                Bitmap.SetPixel(x, y, leftPixel);
                                Progress.Counter++;
                                continue;
                            }
                }
            }
            ChangedOnce();
        }

        public static void CrossEdit()
        {
            for (int x = 1; x < Bitmap.Width - 2; x++)
            {
                for (int y = 1; y < Bitmap.Height - 2; y++)
                {
                    //store pixels
                    curPixel = Bitmap.GetPixel(x, y);
                    upRightPixel = Bitmap.GetPixel(x + 1, y - 1);
                    rightDownPixel = Bitmap.GetPixel(x + 1, y + 1);
                    downLeftPixel = Bitmap.GetPixel(x - 1, y + 1);
                    leftUpPixel = Bitmap.GetPixel(x - 1, y - 1);

                    //comparing
                    if (upRightPixel.Equals(rightDownPixel))
                        if (upRightPixel.Equals(downLeftPixel))
                            if (upRightPixel.Equals(leftUpPixel))
                                if (!upRightPixel.Equals(curPixel))
                                {
                                    Bitmap.SetPixel(x, y, upRightPixel);
                                    Progress.Counter++;
                                }
                }
            }
            ChangedOnce();
        }

        public static void LighterEdit()
        {
            for (int x = 1; x < Bitmap.Width - 2; x++)
            {
                for (int y = 1; y < Bitmap.Height - 2; y++)
                {

                    //store pixels
                    curPixel = Bitmap.GetPixel(x, y);
                    upPixel = Bitmap.GetPixel(x, y - 1);
                    downPixel = Bitmap.GetPixel(x, y + 1);
                    rightPixel = Bitmap.GetPixel(x + 1, y);
                    leftPixel = Bitmap.GetPixel(x - 1, y);

                    //up-right-oriented comparing
                    if (upPixel.GetSaturation() == rightPixel.GetSaturation())
                        if (curPixel.GetSaturation() > upPixel.GetSaturation())
                        {
                            Bitmap.SetPixel(x, y, upPixel);
                            Progress.Counter++;
                            continue;
                        }

                    //down-right-oriented comparing
                    if (downPixel.GetSaturation() == rightPixel.GetSaturation())
                        if (curPixel.GetSaturation() > downPixel.GetSaturation())
                        {
                            Bitmap.SetPixel(x, y, downPixel);
                            Progress.Counter++;
                            continue;
                        }

                    //down-left-oriented comparing
                    if (downPixel.GetSaturation() == leftPixel.GetSaturation())
                        if (curPixel.GetSaturation() > downPixel.GetSaturation())
                        {
                            Bitmap.SetPixel(x, y, downPixel);
                            Progress.Counter++;
                            continue;
                        }

                    //up-left-oriented comparing
                    if (upPixel.GetSaturation() == leftPixel.GetSaturation())
                        if (curPixel.GetSaturation() > upPixel.GetSaturation())
                        {
                            Bitmap.SetPixel(x, y, upPixel);
                            Progress.Counter++;
                            continue;
                        }
                }
            }
            ChangedOnce();
        }

        public static void DarkerEdit()
        {

            for (int x = 1; x < Bitmap.Width - 2; x++)
            {
                for (int y = 1; y < Bitmap.Height - 2; y++)
                {
                    //store pixels
                    curPixel = Bitmap.GetPixel(x, y);
                    upPixel = Bitmap.GetPixel(x, y - 1);
                    downPixel = Bitmap.GetPixel(x, y + 1);
                    rightPixel = Bitmap.GetPixel(x + 1, y);
                    leftPixel = Bitmap.GetPixel(x - 1, y);

                    //up-right-oriented comparing
                    if (upPixel.GetSaturation() == rightPixel.GetSaturation())
                        if (curPixel.GetSaturation() < upPixel.GetSaturation())
                        {
                            Bitmap.SetPixel(x, y, upPixel);
                            Progress.Counter++;
                            continue;
                        }

                    //down-right-oriented comparing
                    if (downPixel.GetSaturation() == rightPixel.GetSaturation())
                        if (curPixel.GetSaturation() < downPixel.GetSaturation())
                        {
                            Bitmap.SetPixel(x, y, downPixel);
                            Progress.Counter++;
                            continue;
                        }

                    //down-left-oriented comparing
                    if (downPixel.GetSaturation() == leftPixel.GetSaturation())
                        if (curPixel.GetSaturation() < downPixel.GetSaturation())
                        {
                            Bitmap.SetPixel(x, y, downPixel);
                            Progress.Counter++;
                            continue;
                        }

                    //up-left-oriented comparing
                    if (upPixel.GetSaturation() == leftPixel.GetSaturation())
                        if (curPixel.GetSaturation() < upPixel.GetSaturation())
                        {
                            Bitmap.SetPixel(x, y, upPixel);
                            Progress.Counter++;
                            continue;
                        }
                }
            }
            ChangedOnce();
        }
    }
}
