using csglxt716.Model;
using System.Web;

public class GlobalFunc
{
    public static string GetAlert(string msg)
    {
        return @"<script>alert('" + HttpUtility.UrlEncode(msg) + "');</script>";
    }

    public static string GetAlert(string msg, string url)
    {
        return @"<script>alert('" + HttpUtility.UrlEncode(msg) + "');window.location.href='" + url + "'</script>";
    }
}
