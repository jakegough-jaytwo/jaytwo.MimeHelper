using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jaytwo.MimeHelper
{
    // mappings from https://github.com/nginx/nginx/blob/master/conf/mime.types

    public class MediaTypeProvider
    {
        public static string GetMediaTypeFromExtension(string fileExtension)
        {
            var normalizedFileExtension = fileExtension.TrimStart('.').ToLowerInvariant();

            switch (normalizedFileExtension)
            {
                case "html":
                case "htm":
                case "shtml":
                    return MediaType.text_html;
                case "css":
                    return MediaType.text_css;
                case "xml":
                    return MediaType.text_xml;
                case "gif":
                    return MediaType.image_gif;
                case "jpeg":
                case "jpg":
                    return MediaType.image_jpeg;
                case "js":
                    return MediaType.application_javascript;
                case "atom":
                    return MediaType.application_atom_xml;
                case "rss":
                    return MediaType.application_rss_xml;

                case "mml":
                    return MediaType.text_mathml;
                case "txt":
                    return MediaType.text_plain;
                case "jad":
                    return MediaType.text_vnd_sun_j2me_app_descriptor;
                case "wml":
                    return MediaType.text_vnd_wap_wml;
                case "htc":
                    return MediaType.text_x_component;

                case "png":
                    return MediaType.image_png;
                case "svg":
                case "svgz":
                    return MediaType.image_svg_xml;
                case "tif":
                case "tiff":
                    return MediaType.image_tiff;
                case "wbmp":
                    return MediaType.image_vnd_wap_wbmp;
                case "webp":
                    return MediaType.image_webp;
                case "ico":
                    return MediaType.image_x_icon;
                case "jng":
                    return MediaType.image_x_jng;
                case "bmp":
                    return MediaType.image_x_ms_bmp;

                case "woff":
                    return MediaType.font_woff;
                case "woff2":
                    return MediaType.font_woff2;

                case "jar":
                case "war":
                case "ear":
                    return MediaType.application_java_archive;
                case "json":
                    return MediaType.application_json;
                case "hqx":
                    return MediaType.application_mac_binhex40;
                case "doc":
                    return MediaType.application_msword;
                case "pdf":
                    return MediaType.application_pdf;
                case "ps":
                case "eps":
                case "ai":
                    return MediaType.application_postscript;
                case "rtf":
                    return MediaType.application_rtf;
                case "m3u8":
                    return MediaType.application_vnd_apple_mpegurl;
                case "kml":
                    return MediaType.application_vnd_google_earth_kml_xml;
                case "kmz":
                    return MediaType.application_vnd_google_earth_kmz;
                case "xls":
                    return MediaType.application_vnd_ms_excel;
                case "eot":
                    return MediaType.application_vnd_ms_fontobject;
                case "ppt":
                    return MediaType.application_vnd_ms_powerpoint;
                case "odg":
                    return MediaType.application_vnd_oasis_opendocument_graphics;
                case "odp":
                    return MediaType.application_vnd_oasis_opendocument_presentation;
                case "ods":
                    return MediaType.application_vnd_oasis_opendocument_spreadsheet;
                case "odt":
                    return MediaType.application_vnd_oasis_opendocument_text;
                case "pptx":
                    return MediaType.application_vnd_openxmlformats_officedocument_presentationml_presentation;
                case "xlsx":
                    return MediaType.application_vnd_openxmlformats_officedocument_spreadsheetml_sheet;
                case "docx":
                    return MediaType.application_vnd_openxmlformats_officedocument_wordprocessingml_document;
                case "wmlc":
                    return MediaType.application_vnd_wap_wmlc;
                case "7z":
                    return MediaType.application_x_7z_compressed;
                case "cco":
                    return MediaType.application_x_cocoa;
                case "jardiff":
                    return MediaType.application_x_java_archive_diff;
                case "jnlp":
                    return MediaType.application_x_java_jnlp_file;
                case "run":
                    return MediaType.application_x_makeself;
                case "pl":
                case "pm":
                    return MediaType.application_x_perl;
                case "prc":
                case "pdb":
                    return MediaType.application_x_pilot;
                case "rar":
                    return MediaType.application_x_rar_compressed;
                case "rpm":
                    return MediaType.application_x_redhat_package_manager;
                case "sea":
                    return MediaType.application_x_sea;
                case "swf":
                    return MediaType.application_x_shockwave_flash;
                case "sit":
                    return MediaType.application_x_stuffit;
                case "tcl":
                case "tk":
                    return MediaType.application_x_tcl;
                case "der":
                case "pem":
                case "crt":
                    return MediaType.application_x_x509_ca_cert;
                case "xpi":
                    return MediaType.application_x_xpinstall;
                case "xhtml":
                    return MediaType.application_xhtml_xml;
                case "xspf":
                    return MediaType.application_xspf_xml;
                case "zip":
                    return MediaType.application_zip;

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
                    return MediaType.application_octet_stream;

                case "mid":
                case "midi":
                case "kar":
                    return MediaType.audio_midi;
                case "mp3":
                    return MediaType.audio_mpeg;
                case "ogg":
                    return MediaType.audio_ogg;
                case "m4a":
                    return MediaType.audio_x_m4a;
                case "ra":
                    return MediaType.audio_x_realaudio;

                case "3gpp":
                case "3gp":
                    return MediaType.video_3gpp;
                case "ts":
                    return MediaType.video_mp2t;
                case "mp4":
                    return MediaType.video_mp4;
                case "mpeg":
                case "mpg":
                    return MediaType.video_mpeg;
                case "mov":
                    return MediaType.video_quicktime;
                case "webm":
                    return MediaType.video_webm;
                case "flv":
                    return MediaType.video_x_flv;
                case "m4v":
                    return MediaType.video_x_m4v;
                case "mng":
                    return MediaType.video_x_mng;
                case "asx":
                case "asf":
                    return MediaType.video_x_ms_asf;
                case "wmv":
                    return MediaType.video_x_ms_wmv;
                case "avi":
                    return MediaType.video_x_msvideo;

                default:
                    return null;
            }
        }
    }
}
