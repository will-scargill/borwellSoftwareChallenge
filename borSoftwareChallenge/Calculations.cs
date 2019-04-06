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
            // Setting up values as doubles
            double roomWidth = Convert.ToDouble(MainWindow.main.tbRoomWidth.Text);
            double roomLength = Convert.ToDouble(MainWindow.main.tbRoomLength.Text);
            double roomHeight = Convert.ToDouble(MainWindow.main.tbRoomHeight.Text);

            double floorArea = roomLength * roomWidth;

            double wallArea = (roomWidth * roomHeight) * 2 + (roomLength * roomHeight) * 2;

            double roomVol = roomWidth * roomHeight * roomLength; 
          
            if (MainWindow.main.recesses.Count == 0) { } // If there are no recesses
            else
            {
                foreach (Recess r in MainWindow.main.recesses) // For each recess
                {
                    if (r.IsDoor == true) // If recess is a door
                    {
                        floorArea += r.Width * r.Depth; // Add the floor area of the recess to overall floor area
                    }
                    wallArea -= (r.Width * r.Height); // Remove wall area taken up by the recess
                    wallArea += r.GetArea(); // Add recess area to overall area
                    roomVol += r.GetVolume(); // Add recess volume to overall volume
                }
            }

            double volOfPaint = (wallArea / 32) * 2.5; // Calculate volume of paint required in litres based on typical coverage (32m^2 for l.5L)

            // Set output textboxes values to calculated values
            MainWindow.main.tbFloorArea.Text = floorArea.ToString();
            MainWindow.main.tbPaintRequired.Text = wallArea.ToString();
            MainWindow.main.tbRoomVolume.Text = roomVol.ToString();

            MainWindow.main.tbPaintVolReq.Text = volOfPaint.ToString();
        }
    }
}
