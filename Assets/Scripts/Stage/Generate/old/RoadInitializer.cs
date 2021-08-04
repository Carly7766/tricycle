// using UnityEngine;
// using UnityEngine.U2D;
// using VContainer.Unity;
//
// namespace Stage.Generate
// {
//     public class RoadInitializer : IInitializable
//     {
//         private readonly GenerateSettings _generateSettings;
//         private Camera _camera;
//         private RoadPathDrawer _roadPathDrawer;
//
//         private RoadInitializer(GenerateSettings generateSettings, Camera camera, RoadPathDrawer roadPathDrawer)
//         {
//             _generateSettings = generateSettings;
//             _camera = camera;
//             _roadPathDrawer = roadPathDrawer;
//         }
//
//         public void Initialize()
//         {
//             var shapeController =
//                 Object.Instantiate(_generateSettings.roadPrefab).GetComponent<SpriteShapeController>();
//
//             var spline = shapeController.spline;
//             spline.Clear();
//             var a = _camera.ScreenToWorldPoint(new Vector3(0, Screen.height / 4, 0));
//             var b = _camera.ScreenToWorldPoint(new Vector3(Screen.width / 2, Screen.height / 4, 0));
//             var c = _camera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height / 4, 0));
//
//             spline.InsertPointAt(0, a);
//             spline.InsertPointAt(1, b);
//             spline.InsertPointAt(2, c);
//
//             _roadPathDrawer.RegisterDraw(spline);
//         }
//     }
// }
