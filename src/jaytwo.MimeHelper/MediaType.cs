#pragma warning disable SA1310 // Field names must not contain underscore
#pragma warning disable SA1303 // Const field names must begin with upper-case letter

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jaytwo.MimeHelper
{
    public class MediaType
    {
        // types from https://github.com/nginx/nginx/blob/master/conf/mime.types

        public const string text_html = "text/html";
        public const string text_css = "text/css";
        public const string text_xml = "text/xml";
        public const string image_gif = "image/gif";
        public const string image_jpeg = "image/jpeg";
        public const string application_javascript = "application/javascript";
        public const string application_atom_xml = "application/atom+xml";
        public const string application_rss_xml = "application/rss+xml";

        public const string text_mathml = "text/mathml";
        public const string text_plain = "text/plain";
        public const string text_vnd_sun_j2me_app_descriptor = "text/vnd.sun.j2me.app-descriptor";
        public const string text_vnd_wap_wml = "text/vnd.wap.wml";
        public const string text_x_component = "text/x-component";

        public const string image_png = "image/png";
        public const string image_svg_xml = "image/svg+xml";
        public const string image_tiff = "image/tiff";
        public const string image_vnd_wap_wbmp = "image/vnd.wap.wbmp";
        public const string image_webp = "image/webp";
        public const string image_x_icon = "image/x-icon";
        public const string image_x_jng = "image/x-jng";
        public const string image_x_ms_bmp = "image/x-ms-bmp";

        public const string font_woff = "font/woff";
        public const string font_woff2 = "font/woff2";

        public const string application_java_archive = "application/java-archive";
        public const string application_json = "application/json";
        public const string application_mac_binhex40 = "application/mac-binhex40";
        public const string application_msword = "application/msword";
        public const string application_pdf = "application/pdf";
        public const string application_postscript = "application/postscript";
        public const string application_rtf = "application/rtf";
        public const string application_vnd_apple_mpegurl = "application/vnd.apple.mpegurl";
        public const string application_vnd_google_earth_kml_xml = "application/vnd.google-earth.kml+xml";
        public const string application_vnd_google_earth_kmz = "application/vnd.google-earth.kmz";
        public const string application_vnd_ms_excel = "application/vnd.ms-excel";
        public const string application_vnd_ms_fontobject = "application/vnd.ms-fontobject";
        public const string application_vnd_ms_powerpoint = "application/vnd.ms-powerpoint";
        public const string application_vnd_oasis_opendocument_graphics = "application/vnd.oasis.opendocument.graphics";
        public const string application_vnd_oasis_opendocument_presentation = "application/vnd.oasis.opendocument.presentation";
        public const string application_vnd_oasis_opendocument_spreadsheet = "application/vnd.oasis.opendocument.spreadsheet";
        public const string application_vnd_oasis_opendocument_text = "application/vnd.oasis.opendocument.text";
        public const string application_vnd_openxmlformats_officedocument_presentationml_presentation = "application/vnd.openxmlformats-officedocument.presentationml.presentation";
        public const string application_vnd_openxmlformats_officedocument_spreadsheetml_sheet = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
        public const string application_vnd_openxmlformats_officedocument_wordprocessingml_document = "application/vnd.openxmlformats-officedocument.wordprocessingml.document";
        public const string application_vnd_wap_wmlc = "application/vnd.wap.wmlc";

        public const string application_x_7z_compressed = "application/x-7z-compressed";
        public const string application_x_cocoa = "application/x-cocoa";
        public const string application_x_java_archive_diff = "application/x-java-archive-diff";
        public const string application_x_java_jnlp_file = "application/x-java-jnlp-file";
        public const string application_x_makeself = "application/x-makeself";
        public const string application_x_perl = "application/x-perl";
        public const string application_x_pilot = "application/x-pilot";
        public const string application_x_rar_compressed = "application/x-rar-compressed";
        public const string application_x_redhat_package_manager = "application/x-redhat-package-manager";
        public const string application_x_sea = "application/x-sea";
        public const string application_x_shockwave_flash = "application/x-shockwave-flash";
        public const string application_x_stuffit = "application/x-stuffit";
        public const string application_x_tcl = "application/x-tcl";
        public const string application_x_x509_ca_cert = "application/x-x509-ca-cert";
        public const string application_x_xpinstall = "application/x-xpinstall";
        public const string application_xhtml_xml = "application/xhtml+xml";
        public const string application_xspf_xml = "application/xspf+xml";
        public const string application_zip = "application/zip";

        public const string application_octet_stream = "application/octet-stream";

        public const string audio_midi = "audio/midi";
        public const string audio_mpeg = "audio/mpeg";
        public const string audio_ogg = "audio/ogg";
        public const string audio_x_m4a = "audio/x-m4a";
        public const string audio_x_realaudio = "audio/x-realaudio";

        public const string video_3gpp = "video/3gpp";
        public const string video_mp2t = "video/mp2t";
        public const string video_mp4 = "video/mp4";
        public const string video_mpeg = "video/mpeg";
        public const string video_quicktime = "video/quicktime";
        public const string video_webm = "video/webm";
        public const string video_x_flv = "video/x-flv";
        public const string video_x_m4v = "video/x-m4v";
        public const string video_x_mng = "video/x-mng";
        public const string video_x_ms_asf = "video/x-ms-asf";
        public const string video_x_ms_wmv = "video/x-ms-wmv";
        public const string video_x_msvideo = "video/x-msvideo";

        // types not include above (likely because they don't map to a file extension)

        public const string application_x_www_form_urlencoded = "application/x-www-form-urlencoded";
        public const string multipart_form_data = "multipart/form-data";
    }
}
#pragma warning restore SA1310 // Field names must not contain underscore
#pragma warning restore SA1303 // Const field names must begin with upper-case letter
