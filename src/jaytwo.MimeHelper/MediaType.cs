#pragma warning disable SA1310 // Field names must not contain underscore
#pragma warning disable SA1303 // Const field names must begin with upper-case letter

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jaytwo.MimeHelper
{
    // types from https://github.com/nginx/nginx/blob/master/conf/mime.types

    public class MediaType
    {
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

        public static string GetMediaTypeFromExtension(string fileExtension)
        {
            var normalizedFileExtension = fileExtension.TrimStart('.').ToLowerInvariant();

            switch (normalizedFileExtension)
            {
                case "html":
                case "htm":
                case "shtml":
                    return text_html;
                case "css":
                    return text_css;
                case "xml":
                    return text_xml;
                case "gif":
                    return image_gif;
                case "jpeg":
                case "jpg":
                    return image_jpeg;
                case "js":
                    return application_javascript;
                case "atom":
                    return application_atom_xml;
                case "rss":
                    return application_rss_xml;

                case "mml":
                    return text_mathml;
                case "txt":
                    return text_plain;
                case "jad":
                    return text_vnd_sun_j2me_app_descriptor;
                case "wml":
                    return text_vnd_wap_wml;
                case "htc":
                    return text_x_component;

                case "png":
                    return image_png;
                case "svg":
                case "svgz":
                    return image_svg_xml;
                case "tif":
                case "tiff":
                    return image_tiff;
                case "wbmp":
                    return image_vnd_wap_wbmp;
                case "webp":
                    return image_webp;
                case "ico":
                    return image_x_icon;
                case "jng":
                    return image_x_jng;
                case "bmp":
                    return image_x_ms_bmp;

                case "woff":
                    return font_woff;
                case "woff2":
                    return font_woff2;

                case "jar":
                case "war":
                case "ear":
                    return application_java_archive;
                case "json":
                    return application_json;
                case "hqx":
                    return application_mac_binhex40;
                case "doc":
                    return application_msword;
                case "pdf":
                    return application_pdf;
                case "ps":
                case "eps":
                case "ai":
                    return application_postscript;
                case "rtf":
                    return application_rtf;
                case "m3u8":
                    return application_vnd_apple_mpegurl;
                case "kml":
                    return application_vnd_google_earth_kml_xml;
                case "kmz":
                    return application_vnd_google_earth_kmz;
                case "xls":
                    return application_vnd_ms_excel;
                case "eot":
                    return application_vnd_ms_fontobject;
                case "ppt":
                    return application_vnd_ms_powerpoint;
                case "odg":
                    return application_vnd_oasis_opendocument_graphics;
                case "odp":
                    return application_vnd_oasis_opendocument_presentation;
                case "ods":
                    return application_vnd_oasis_opendocument_spreadsheet;
                case "odt":
                    return application_vnd_oasis_opendocument_text;
                case "pptx":
                    return application_vnd_openxmlformats_officedocument_presentationml_presentation;
                case "xlsx":
                    return application_vnd_openxmlformats_officedocument_spreadsheetml_sheet;
                case "docx":
                    return application_vnd_openxmlformats_officedocument_wordprocessingml_document;
                case "wmlc":
                    return application_vnd_wap_wmlc;
                case "7z":
                    return application_x_7z_compressed;
                case "cco":
                    return application_x_cocoa;
                case "jardiff":
                    return application_x_java_archive_diff;
                case "jnlp":
                    return application_x_java_jnlp_file;
                case "run":
                    return application_x_makeself;
                case "pl":
                case "pm":
                    return application_x_perl;
                case "prc":
                case "pdb":
                    return application_x_pilot;
                case "rar":
                    return application_x_rar_compressed;
                case "rpm":
                    return application_x_redhat_package_manager;
                case "sea":
                    return application_x_sea;
                case "swf":
                    return application_x_shockwave_flash;
                case "sit":
                    return application_x_stuffit;
                case "tcl":
                case "tk":
                    return application_x_tcl;
                case "der":
                case "pem":
                case "crt":
                    return application_x_x509_ca_cert;
                case "xpi":
                    return application_x_xpinstall;
                case "xhtml":
                    return application_xhtml_xml;
                case "xspf":
                    return application_xspf_xml;
                case "zip":
                    return application_zip;

                case "bin":
                case "exe":
                case "dll":
                case "deb":
                case "dmg":
                case "iso":
                case "img":
                case "msi":
                case "msp":
                case "msm":
                    return application_octet_stream;

                case "mid":
                case "midi":
                case "kar":
                    return audio_midi;
                case "mp3":
                    return audio_mpeg;
                case "ogg":
                    return audio_ogg;
                case "m4a":
                    return audio_x_m4a;
                case "ra":
                    return audio_x_realaudio;

                case "3gpp":
                case "3gp":
                    return video_3gpp;
                case "ts":
                    return video_mp2t;
                case "mp4":
                    return video_mp4;
                case "mpeg":
                case "mpg":
                    return video_mpeg;
                case "mov":
                    return video_quicktime;
                case "webm":
                    return video_webm;
                case "flv":
                    return video_x_flv;
                case "m4v":
                    return video_x_m4v;
                case "mng":
                    return video_x_mng;
                case "asx":
                case "asf":
                    return video_x_ms_asf;
                case "wmv":
                    return video_x_ms_wmv;
                case "avi":
                    return video_x_msvideo;

                default:
                    return null;
            }
        }
    }
}
#pragma warning restore SA1310 // Field names must not contain underscore
#pragma warning restore SA1303 // Const field names must begin with upper-case letter
