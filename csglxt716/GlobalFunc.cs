using csglxt716.Model;

public class GlobalFunc
{
    public static string GetAlert(string msg)
    {
        return @"<script>alert('"+msg+"');</script>";
    }

    public static string GetAlert(string msg, string url)
    {
        return @"<script>alert('" + msg + "');window.location.href='" + url + "'</script>";
    }
}