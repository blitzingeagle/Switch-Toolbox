using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using SharpGLTF.Materials;
using SharpGLTF.Scenes;

namespace Toolbox.Library.Gltf
{
    public class GLTFBuilder
    {
        private SceneBuilder Scene;
        private MaterialBuilder DefaultMaterial;

        public GLTFBuilder()
        {
            Scene = new SceneBuilder();
            DefaultMaterial = new MaterialBuilder()
                .WithMetallicRoughnessShader()
                .WithBaseColor(new Vector4(1, 1, 1, 1));
        }

        public void AddMesh()
        {
            /*
            var meshbuilder = new MeshBuilder<VertexPositionNormal, VertexTexture1, VertexEmpty>(mesh.Text);
            var prim = meshbuilder.UsePrimitive(material);

            var vert0 = new VertexBuilder<VertexPositionNormal, VertexTexture1, VertexEmpty>();
            Vector3 position0 = new Vector3(v0.pos.X, v0.pos.Y, v0.pos.Z);
            Vector3 normal0 = new Vector3(v0.nrm.X, v0.nrm.Y, v0.nrm.Z);
            vert0.Geometry = new VertexPositionNormal(position0, normal0);
            vert0.Material = new VertexTexture1();

            prim.AddTriangle(
                new VertexPosition(new Vector3(v0.pos.X, v0.pos.Y, v0.pos.Z)),
                new VertexPosition(new Vector3(v1.pos.X, v1.pos.Y, v1.pos.Z)),
                new VertexPosition(new Vector3(v2.pos.X, v2.pos.Y, v2.pos.Z))
            );

            scene.AddRigidMesh(meshbuilder, Matrix4x4.CreateScale(0.001f));  // millimeters to meters
            */
        }

        public void Write(string FileName)
        {
            var model = Scene.ToGltf2();
            model.SaveGLTF(FileName);
        }
    }
}
