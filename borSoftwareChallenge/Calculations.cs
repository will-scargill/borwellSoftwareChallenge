using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace borSoftwareChallenge
{
    class Calculations
    {

        public static void FillOutputs()
        {
            double roomWidth = Convert.ToDouble(MainWindow.main.tbRoomWidth.Text);
            double roomLength = Convert.ToDouble(MainWindow.main.tbRoomLength.Text);
            double roomHeight = Convert.ToDouble(MainWindow.main.tbRoomHeight.Text);

            double floorArea = roomLength * roomWidth;

            double wallArea = (roomWidth * roomHeight) * 2 + (roomLength * roomHeight) * 2; 

            double roomVol = roomWidth * roomHeight * roomLength; 
          
            if (MainWindow.main.recesses.Count == 0) { }
            else
            {
                double additionalArea = 0;
                double additionalVol = 0;

                foreach (Recess r in MainWindow.main.recesses)
                {
                    if (r.IsDoor == true)
                    {
                        floorArea += r.Width * r.Depth;
                    }
                    wallArea -= (r.Width * r.Height);
                    additionalArea += r.GetArea();
                    additionalVol += r.GetVolume();
                }
                wallArea += additionalArea;
                roomVol += additionalVol;
            }

            double volOfPaint = (wallArea / 32) * 2.5;

            MainWindow.main.tbFloorArea.Text = floorArea.ToString();
            MainWindow.main.tbPaintRequired.Text = wallArea.ToString();
            MainWindow.main.tbRoomVolume.Text = roomVol.ToString();

            MainWindow.main.tbPaintVolReq.Text = volOfPaint.ToString();
        }
    }
}
