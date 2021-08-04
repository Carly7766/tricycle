// using UniRx;
// using UnityEngine;
// using UnityEngine.U2D;
//
// namespace Stage.Generate
// {
//     public class RoadPathDrawer
//     {
//         private readonly GenerateSettings _generateSettings;
//         private readonly Camera _camera;
//
//         float y = 0;
//
//         public RoadPathDrawer(GenerateSettings generateSettings, Camera camera)
//         {
//             _generateSettings = generateSettings;
//             _camera = camera;
//         }
//
//         public void RegisterDraw(Spline spline)
//         {
//             _camera.transform
//                 .ObserveEveryValueChanged(t => t.position.x)
//                 .Select(x => x + _generateSettings.aheadGenerateWidth)
//                 .Where(aheadX => aheadX > GetLastPoint().x)
//                 .Subscribe(x =>
//                 {
//                     Vector2 MakePoint;
//                     Vector2 nextMakePoint = GetNextPoint();
//                     nextMakePoint = (nextMakePoint - (Vector2) spline.GetPosition(spline.GetPointCount() - 1)) + nextMakePoint;
//
//                     while (x > GetLastPoint().x)
//                     {
//                         MakePoint = nextMakePoint;
//                         
//                         spline.InsertPointAt(spline.GetPointCount(), MakePoint);
//
//                         SetTangent();
//
//                         nextMakePoint = GetNextPoint();
//                         nextMakePoint = (nextMakePoint - (Vector2) spline.GetPosition(spline.GetPointCount() - 1)) + nextMakePoint;
//
//                         SetNextTangent(nextMakePoint);
//                     }
//
//                     void SetNextTangent(Vector3 d)
//                     {
//                         var b = spline.GetPosition(spline.GetPointCount() - 2);
//
//                         var bd = d - b;
//
//                         var rad = Mathf.Atan2(bd.y, bd.x);
//                         var angle = new Vector3(Mathf.Cos(rad), Mathf.Sin(rad)) * (bd.magnitude / 3);
//
//                         spline.SetTangentMode(spline.GetPointCount() - 1, ShapeTangentMode.Continuous);
//                         spline.SetLeftTangent(spline.GetPointCount() - 1, -angle);
//                     }
//
//                     void SetTangent()
//                     {
//                         var a = spline.GetPosition(spline.GetPointCount() - 3);
//                         var c = spline.GetPosition(spline.GetPointCount() - 1);
//
//                         var ac = c - a;
//
//                         var rad = Mathf.Atan2(ac.y, ac.x);
//                         var angle = new Vector3(Mathf.Cos(rad), Mathf.Sin(rad)) * (ac.magnitude / 3);
//
//                         spline.SetTangentMode(spline.GetPointCount() - 2, ShapeTangentMode.Continuous);
//                         spline.SetRightTangent(spline.GetPointCount() - 2, angle);
//                     }
//                 });
//
//             Vector3 GetLastPoint()
//             {
//                 return spline.GetPosition(spline.GetPointCount() - 1);
//             }
//
//             Vector3 GetNextPoint()
//             {
//                 y += Random.Range(-Mathf.PI / 2, Mathf.PI / 2);
//                 return new Vector2(GetLastPoint().x + 10,
//                     Mathf.Sin(y * _camera.ViewportToWorldPoint(Vector2.one).y));
//             }
//         }
//     }
// }
