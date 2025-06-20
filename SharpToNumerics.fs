﻿module SharpToNumerics

open SharpDX
open System.Numerics

let vec2 (v: SharpDX.Vector2) = Vector2(v.X, v.Y)
let vec3 (v: SharpDX.Vector3) = Vector3(v.X, v.Y, v.Z)
let vec4 (v: SharpDX.Vector4) = Vector4(v.X, v.Y, v.Z, v.W)

let col (v: SharpDX.Color) =
    Vector4(
        float32 v.R / 255.0f, 
        float32 v.G / 255.0f, 
        float32 v.B / 255.0f, 
        float32 v.A / 255.0f
    )

let vec4col (v: SharpDX.Color) = Vector4(float32 v.R, float32 v.G, float32 v.B, float32 v.A)

let convertColor (rgba: byte[]) =
    Vector4(
        float32 rgba.[0] / 255.0f,
        float32 rgba.[1] / 255.0f,
        float32 rgba.[2] / 255.0f,
        float32 rgba.[3] / 255.0f
    )

let halfToVec4 (inputAray: Half[]) : Vector4 =
    match inputAray.Length with
    | l when l >= 4 ->
        Vector4(float32 inputAray[0], float32 inputAray[1], float32 inputAray[2], float32 inputAray[3])
    | l when l >= 3 ->
        Vector4(float32 inputAray[0], float32 inputAray[1], float32 inputAray[2], 1.0f)
    | _ -> Vector4.Zero