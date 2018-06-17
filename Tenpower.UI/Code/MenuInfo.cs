using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tenpower.UI
{
    public class MenuInfo
    {
        public MenuInfo() 
        {
            this.Children = new List<MenuInfo>();
        }

        public int Id { get; set; }
        public int Pid { get; set; }
        public string Ico { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public bool IsLeaf { get; set; }
        public bool IsRoot { get; set; }
        public int Order { get{return this.Id;} }
        public MenuInfo Parent { get; set; }
        public List<MenuInfo> Children { get; set; }
        public string ViewPath { set; get; }
        public static List<MenuInfo> Create()
        {
            List<MenuInfo> lstMenuInfo = new List<MenuInfo>();
            lstMenuInfo.Add(new MenuInfo() { Ico = "", Id = 1, Name = "晴雨表", Pid = 0, Url = "/barometer/home/index" });
            lstMenuInfo.Add(new MenuInfo() { Ico = "", Id = 11, Name = "BMP一次加工质量月报", Pid = 1, Url = "/barometer/m1/quality/bmp" });
            lstMenuInfo.Add(new MenuInfo() { Ico = "", Id = 12, Name = "BMP二次加工质量月报", Pid = 1, Url = "/barometer/m2/quality/bmp" });
            lstMenuInfo.Add(new MenuInfo() { Ico = "", Id = 13, Name = "CP前端质量月报", Pid = 1, Url = "/barometer/m1/quality/cp" });
            lstMenuInfo.Add(new MenuInfo() { Ico = "", Id = 14, Name = "CP后端端质量月报", Pid = 1, Url = "/barometer/m2/quality/cp" });

            lstMenuInfo.Add(new MenuInfo() { Ico = "", Id = 2, Name = "一次加工", Pid = 0, Url = "/m1/home/index" });
            lstMenuInfo.Add(new MenuInfo() { Ico = "", Id = 21, Name = "BMP直通率", Pid =2, Url = "/m1/throughrate/bmp" });
            lstMenuInfo.Add(new MenuInfo() { Ico = "", Id = 22, Name = "适配器生产精细化", Pid = 2, Url = "/m1/manualanalysis/adapter" });

            lstMenuInfo.Add(new MenuInfo() { Ico = "", Id = 3, Name = "二次加工", Pid = 0, Url = "/m2/home/index" });
            lstMenuInfo.Add(new MenuInfo() { Ico = "", Id = 31, Name = "BMP的Fdppm", Pid = 3, Url = "/m2/fdppm/bmp" });
            lstMenuInfo.Add(new MenuInfo() { Ico = "", Id = 32, Name = "BMP维修IT化", Pid = 3, Url = "/m2/ittools/bmp" });

            lstMenuInfo.Add(new MenuInfo() { Ico = "", Id = 4, Name = "存量经营", Pid = 0, Url = "#" });
            lstMenuInfo.Add(new MenuInfo() { Ico = "", Id = 41, Name = "BMP浴盆曲线", Pid = 4, Url = "#" });

            lstMenuInfo.Add(new MenuInfo() { Ico = "", Id = 5, Name = "来料大数据", Pid = 0, Url = "#" });
            lstMenuInfo.Add(new MenuInfo() { Ico = "", Id = 51, Name = "供需保障", Pid = 5, Url = "#" });
            lstMenuInfo.Add(new MenuInfo() { Ico = "", Id = 52, Name = "精准抽样", Pid = 5, Url = "#" });
         

            lstMenuInfo.Add(new MenuInfo() { Ico = "", Id = 6, Name = "系统设置", Pid = 0, Url = "/admin/#/#" });
            lstMenuInfo.Add(new MenuInfo() { Ico = "", Id = 61, Name = "基础数据", Pid = 6, Url = "/admin/datamanager/#" });
            lstMenuInfo.Add(new MenuInfo() { Ico = "", Id = 611, Name = "Import", Pid = 61, Url = "/admin/datamanager/import" });
            lstMenuInfo.Add(new MenuInfo() { Ico = "", Id = 612, Name = "M1测试记录", Pid = 61, Url = "/admin/datamanager/m1" });
            lstMenuInfo.Add(new MenuInfo() { Ico = "", Id = 613, Name = "M2失效记录", Pid = 61, Url = "/admin/datamanager/m2" });
            lstMenuInfo.Add(new MenuInfo() { Ico = "", Id = 614, Name = "市场失效记录", Pid = 61, Url = "/admin/datamanager/market" });
            lstMenuInfo.Add(new MenuInfo() { Ico = "", Id = 62, Name = "权限管理", Pid = 6, Url = "/admin/actionmanager/#" });
            lstMenuInfo.Add(new MenuInfo() { Ico = "", Id = 621, Name = "用户信息", Pid = 62, Url = "/admin/actionmanager/userInfo" });
            lstMenuInfo.Add(new MenuInfo() { Ico = "", Id = 622, Name = "角色信息", Pid = 62, Url = "/admin/actionmanager/roleInfo" });
            lstMenuInfo.Add(new MenuInfo() { Ico = "", Id = 623, Name = "菜单信息", Pid = 62, Url = "/admin/actionmanager/menuInfo" });


            lstMenuInfo.Add(new MenuInfo() { Ico = "", Id = 7, Name = "开发者", Pid = 0, Url = "/dev/#/#" });
            lstMenuInfo.Add(new MenuInfo() { Ico = "", Id = 71, Name = "正文", Pid = 7, Url = "/dev/doc/item" });
            lstMenuInfo.Add(new MenuInfo() { Ico = "", Id = 72, Name = "新随笔", Pid = 7, Url = "/dev/doc/add" });
            
            return lstMenuInfo;
        }
    }
}