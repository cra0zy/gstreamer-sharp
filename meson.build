project('gstreamer-sharp', ['cs', 'c'], version: '1.12.0')

# Will do the necessary mono compiler checks
gtk_sharp = subproject('gtk-sharp')

if host_machine.system() == 'osx'
  lib_prefix=''
  lib_suffix='.dylib'
else
  lib_prefix='.so'
  lib_suffix=''
endif

gacutil = find_program('gacutil')
glib_sharp_dep = gtk_sharp.get_variable('glib_sharp_dep')
gio_sharp_dep = gtk_sharp.get_variable('gio_sharp_dep')
gapi_fixup = gtk_sharp.get_variable('gapi_fixup')
gapi_codegen = gtk_sharp.get_variable('gapi_codegen')
glib_api_includes = gtk_sharp.get_variable('glib_api_includes')
gio_api_includes = gtk_sharp.get_variable('gio_api_includes')
generate_api = gtk_sharp.get_variable('generate_api')
gacutil_install = gtk_sharp.get_variable('gacutil_install')

# TODO Handle monodoc

apiversion = '1.0'
gst_required_version = '>=@0@'.format(meson.project_version())
gst_deps = []

foreach dep: [
  ['gstreamer', ['gstreamer', 'gst_dep']],
  ['gstreamer-app', ['gst-plugins-base', 'app_dep']],
  ['gstreamer-audio', ['gst-plugins-base', 'audio_dep']],
  ['gstreamer-base', ['gst-plugins-base', 'audio_dep']],
  ['gstreamer-controller', ['gstreamer', 'gst_controller_dep']],
  ['gstreamer-fft', ['gst-plugins-base', 'fft_dep']],
  ['gstreamer-net', ['gstreamer', 'gst_net_dep']],
  ['gstreamer-pbutils', ['gst-plugins-base', 'pbutils_dep']],
  ['gstreamer-riff', ['gst-plugins-base', 'riff_dep']],
  ['gstreamer-rtp', ['gst-plugins-base', 'rtp_dep']],
  ['gstreamer-rtsp', ['gst-plugins-base', 'rtsp_dep']],
  ['gstreamer-sdp', ['gst-plugins-base', 'sdp_dep']],
  ['gstreamer-tag', ['gst-plugins-base', 'tag_dep']],
  ['gstreamer-video', ['gst-plugins-base', 'video_dep']],]

  gst_deps += [dependency(dep.get(0) + '-' + apiversion, version: gst_required_version,
    fallback: dep.get(1))]
endforeach

subdir('sources')
subdir('samples')
