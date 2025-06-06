# Copyright (c) 2021 homuler
#
# Use of this source code is governed by an MIT-style
# license that can be found in the LICENSE file or at
# https://opensource.org/licenses/MIT.

load("@build_bazel_rules_apple//apple:ios.bzl", "ios_framework")

objc_library(
    name = "mediapipe_c_ios",
    sdk_frameworks = [
        "Accelerate",
        "AVFoundation",
        "CoreVideo",
        "CoreGraphics",
        "CoreMedia",
        "GLKit",
        "OpenGLES",
        "QuartzCore",
    ],
    deps = [
        "//mediapipe_api:mediapipe_c",
    ] + select({
        "@opencv//:opencv_ios_source_build": ["@ios_opencv_source//:opencv_xcframework"],
        "//conditions:default": ["@ios_opencv//:OpencvFramework"],
    }),
)

ios_framework(
    name = "MediaPipeUnity",
    bundle_id = "com.github.homuler.mediapipe.unity",
    families = [
        "iphone",
        "ipad",
    ],
    infoplists = ["Info.plist"],
    minimum_os_version = "12.0",
    visibility = ["//visibility:public"],
    deps = [
        ":mediapipe_c_ios",
    ],
)
