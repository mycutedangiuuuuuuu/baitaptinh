using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using Newtonsoft.Json;
using lib_hinhhoc;

namespace web_v2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.HttpMethod == "POST")
            {
                try
                {
                    string jsonString = new System.IO.StreamReader(Request.InputStream).ReadToEnd();
                    var data = JsonConvert.DeserializeObject<Dictionary<string, double>>(jsonString);

                    double dai = data["chieudai"];
                    double rong = data["chieurong"];

                    hinhchunhat hcn = new hinhchunhat();
                    hcn.a = dai;
                    hcn.b = rong;
                    hcn.Xuly();

                    if (hcn.ok)
                    {
                        var result = new
                        {
                            chuvi = hcn.chuvi,
                            dientich = hcn.dientich
                        };

                        Response.ContentType = "application/json";
                        Response.Write(JsonConvert.SerializeObject(result));
                    }
                    else
                    {
                        Response.Write("Lỗi!!! vui lòng nhập lại .");
                    }
                }
                catch (Exception ex)
                {
                    Response.Write("Lỗi: " + ex.Message);
                }
            }
        }
    }
}
