using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Events;


namespace bai2ngay4_3
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    public class Class1 : IExternalCommand
    {

public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIDocument uidoc = commandData.Application.ActiveUIDocument;
            Document doc = uidoc.Document;
            FilteredElementCollector collector = new FilteredElementCollector(doc);
            ElementCategoryFilter filter = new ElementCategoryFilter(BuiltInCategory.OST_Walls);
            IList<Element> wallList = collector.WherePasses(filter).WhereElementIsNotElementType().ToElements();
            StringBuilder output = new StringBuilder("ds id tuong la:\r\n\r\n");
            foreach (Element wall in wallList)
            {     
                string wallId = wall.Id.ToString();     
                WallType wallType = doc.GetElement(wall.GetTypeId()) as WallType;
                if (wallType != null)
                {
                    
                    double thickness = ChangeUnitFeetToMillimeter(wallType.Width);

                   
                    output.AppendLine($"id: {wallId}\r\n\r\n do day: {thickness} mm");
                }
            }
            MessageBox.Show(output.ToString());
            return Result.Succeeded;
        }
        static double ChangeUnitFeetToMillimeter(double value)
        {
            return Math.Round(UnitUtils.ConvertFromInternalUnits(value, UnitTypeId.Millimeters), 2);
        }
    }
}
