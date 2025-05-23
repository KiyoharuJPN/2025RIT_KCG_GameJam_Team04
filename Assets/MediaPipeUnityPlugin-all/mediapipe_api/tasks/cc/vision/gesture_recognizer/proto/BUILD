# Copyright (c) 2023 homuler
#
# Use of this source code is governed by an MIT-style
# license that can be found in the LICENSE file or at
# https://opensource.org/licenses/MIT.

load("@rules_pkg//pkg:mappings.bzl", "pkg_files")
load("//mediapipe_api:csharp_proto_src.bzl", "csharp_proto_src")

package(default_visibility = ["//visibility:public"])

pkg_files(
    name = "proto_srcs",
    srcs = [
        ":gesture_embedder_graph_options_cs",
        ":gesture_classifier_graph_options_cs",
        ":gesture_recognizer_graph_options_cs",
        ":hand_gesture_recognizer_graph_options_cs",
    ],
    prefix = "Tasks/Vision/GestureRecognizer/Proto",
)

csharp_proto_src(
    name = "gesture_embedder_graph_options_cs",
    proto_src = "mediapipe/tasks/cc/vision/gesture_recognizer/proto/gesture_embedder_graph_options.proto",
    deps = [
        "@mediapipe//mediapipe/tasks/cc/core/proto:protos_src",
        "@mediapipe//mediapipe/tasks/cc/vision/gesture_recognizer/proto:protos_src",
        "@mediapipe//mediapipe/calculators/tensor:protos_src",
        "@mediapipe//mediapipe/framework:protos_src",
        "@mediapipe//mediapipe/gpu:protos_src",
    ],
)

csharp_proto_src(
    name = "gesture_classifier_graph_options_cs",
    proto_src = "mediapipe/tasks/cc/vision/gesture_recognizer/proto/gesture_classifier_graph_options.proto",
    deps = [
        "@mediapipe//mediapipe/tasks/cc/core/proto:protos_src",
        "@mediapipe//mediapipe/tasks/cc/components/processors/proto:protos_src",
        "@mediapipe//mediapipe/tasks/cc/vision/gesture_recognizer/proto:protos_src",
        "@mediapipe//mediapipe/calculators/tensor:protos_src",
        "@mediapipe//mediapipe/framework:protos_src",
        "@mediapipe//mediapipe/gpu:protos_src",
    ],
)

csharp_proto_src(
    name = "gesture_recognizer_graph_options_cs",
    proto_src = "mediapipe/tasks/cc/vision/gesture_recognizer/proto/gesture_recognizer_graph_options.proto",
    deps = [
        "@mediapipe//mediapipe/tasks/cc/core/proto:protos_src",
        "@mediapipe//mediapipe/tasks/cc/components/processors/proto:protos_src",
        "@mediapipe//mediapipe/tasks/cc/vision/gesture_recognizer/proto:protos_src",
        "@mediapipe//mediapipe/tasks/cc/vision/hand_detector/proto:protos_src",
        "@mediapipe//mediapipe/tasks/cc/vision/hand_landmarker/proto:protos_src",
        "@mediapipe//mediapipe/calculators/tensor:protos_src",
        "@mediapipe//mediapipe/framework:protos_src",
        "@mediapipe//mediapipe/gpu:protos_src",
    ],
)

csharp_proto_src(
    name = "hand_gesture_recognizer_graph_options_cs",
    proto_src = "mediapipe/tasks/cc/vision/gesture_recognizer/proto/hand_gesture_recognizer_graph_options.proto",
    deps = [
        "@mediapipe//mediapipe/tasks/cc/core/proto:protos_src",
        "@mediapipe//mediapipe/tasks/cc/components/processors/proto:protos_src",
        "@mediapipe//mediapipe/tasks/cc/vision/gesture_recognizer/proto:protos_src",
        "@mediapipe//mediapipe/calculators/tensor:protos_src",
        "@mediapipe//mediapipe/framework:protos_src",
        "@mediapipe//mediapipe/gpu:protos_src",
    ],
)
