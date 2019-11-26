using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CorTranform
{

    public struct Cor
    {
        public double lng;
        public double lat;
    }
    public class Transformer
    {
        const double x_pi = 3.14159265358979324 * 3000.0 / 180.0;
        const double pi = 3.1415926535897932384626; // π
        const double a = 6378245.0;// 长半轴
        const double ee = 0.00669342162296594323; // 扁率

        //火星转百度
        public static Cor gcj02tobd09(Cor HxCor)
        {
            double z = Math.Sqrt(HxCor.lng * HxCor.lng + HxCor.lat * HxCor.lat) + 0.00002 * Math.Sin(HxCor.lat * x_pi);
            double theta = Math.Atan2(HxCor.lat, HxCor.lng) + 0.000003 * Math.Cos(HxCor.lng * x_pi);
            Cor BaiduCor;
            BaiduCor.lng = z * Math.Cos(theta) + 0.0065;
            BaiduCor.lat = z * Math.Sin(theta) + 0.006;
            return BaiduCor;
        }

        //百度转火星
        public static Cor bd09togcj02(Cor Bd)
        {
            double x = Bd.lng - 0.0065;
            double y = Bd.lat - 0.006;
            double z = Math.Sqrt(x * x + y * y) - 0.00002 * Math.Sin(y * x_pi);
            double theta = Math.Atan2(y, x) - .000003 * Math.Cos(x * x_pi);
            Cor hx;
            hx.lng = z * Math.Cos(theta);
            hx.lat = z * Math.Sin(theta);
            return hx;
        }

        //WGS84转火星
        public static Cor wgs84togcj02(Cor wgs84)
        {
            if (OutOfChina(wgs84))
            {
                return wgs84;
            }
            double dlat = transformlat(wgs84.lng - 105.0, wgs84.lat - 35.0);
            double dlng = transformlng(wgs84.lng - 105.0, wgs84.lat - 35.0);
            double radlat = wgs84.lat / 180.0 * pi;
            double magic = Math.Sin(radlat);
            magic = 1 - ee * magic * magic;
            double sqrtmagic = Math.Sqrt(magic);
            dlat = (dlat * 180.0) / ((a * (1 - ee)) / (magic * sqrtmagic) * pi);
            dlng = (dlng * 180.0) / (a / sqrtmagic * Math.Cos(radlat) * pi);
            Cor hx;
            hx.lat = wgs84.lat + dlat;
            hx.lng = wgs84.lng + dlng;
            return hx;
        }


        //火星转84
        public static Cor gcj02towgs84(Cor hx)
        {
            if (OutOfChina(hx))
            {
                return hx;
            }
            double dlat = transformlat(hx.lng - 105.0, hx.lat - 35.0);
            double dlng = transformlng(hx.lng - 105.0, hx.lat - 35.0);
            double radlat = hx.lat / 180.0 * pi;
            double magic = Math.Sin(radlat);
            magic = 1 - ee * magic * magic;
            double sqrtmagic = Math.Sqrt(magic);
            dlat = (dlat * 180.0) / ((a * (1 - ee)) / (magic * sqrtmagic) * pi);
            dlng = (dlng * 180.0) / (a / sqrtmagic * Math.Cos(radlat) * pi);
            Cor wgs84;
            double mglat = hx.lat + dlat;
            double mglng = hx.lng + dlng;
            wgs84.lat = hx.lat * 2 -mglat;
            wgs84.lng = hx.lng *2-mglng;
            return wgs84;
        }
        
        //百度转84
        public static Cor bd09towgs84(Cor bd)
        {
            Cor hx = bd09togcj02(bd);
            Cor wgs84 = gcj02towgs84(hx);
            return wgs84;
        }

        //84转百度
        public static Cor wgs84tobd09(Cor wgs84)
        {
            Cor hx = wgs84togcj02(wgs84);
            Cor bd = gcj02tobd09(hx);
            return bd;
        }
        /*辅助函数*/
        //判断是否在国内
        private static Boolean OutOfChina(Cor wgs84)
        {
            if (wgs84.lng < 72.004 || wgs84.lng > 137.8347)
            {
                return true;
            }
            if (wgs84.lat < 0.8293 || wgs84.lat > 55.8271)
            {
                return true;
            }
            return false;
        }

        /*辅助函数*/
        //转换lat
        private static double transformlat(double lng, double lat)
        {
            double ret = -100.0 + 2.0 * lng + 3.0 * lat + 0.2 * lat * lat +
        0.1 * lng * lat + 0.2 * Math.Sqrt(Math.Abs(lng));
    ret += (20.0 * Math.Sin(6.0 * lng * pi) + 20.0 *
            Math.Sin(2.0 * lng * pi)) * 2.0 / 3.0;
    ret += (20.0 * Math.Sin(lat * pi) + 40.0 *
            Math.Sin(lat / 3.0 * pi)) * 2.0 / 3.0;
    ret += (160.0 * Math.Sin(lat / 12.0 * pi) + 320 *
            Math.Sin(lat * pi / 30.0)) * 2.0 / 3.0;
            return ret;
        }

        /*辅助函数*/
        //转换lng
        private static double transformlng(double lng, double lat)
        {
            double ret = 300.0 + lng + 2.0 * lat + 0.1 * lng * lng +
        0.1 * lng * lat + 0.1 * Math.Sqrt(Math.Abs(lng));
            ret += (20.0 * Math.Sin(6.0 * lng * pi) + 20.0 *
                    Math.Sin(2.0 * lng * pi)) * 2.0 / 3.0;
            ret += (20.0 * Math.Sin(lng * pi) + 40.0 *
                    Math.Sin(lng / 3.0 * pi)) * 2.0 / 3.0;
            ret += (150.0 * Math.Sin(lng / 12.0 * pi) + 300.0 *
                    Math.Sin(lng / 30.0 * pi)) * 2.0 / 3.0;
            return ret;
        }

        // 按类计算
        public static   Cor transform(Cor corOld,string transType)
        {
            switch (transType)
            {
                case "百度转火星":   
                        return Transformer.bd09togcj02(corOld);
                case "百度转84":
                        return Transformer.bd09towgs84(corOld);
                case "火星转84":    
                        return Transformer.gcj02towgs84(corOld);
                case "84转火星":
                        return Transformer.wgs84togcj02(corOld);
                case "火星转百度":
                        return Transformer.gcj02tobd09(corOld);
                case "84转百度":
                        return Transformer.wgs84tobd09(corOld);
                default:
                    return corOld;
            }
            
        }
    }
}
