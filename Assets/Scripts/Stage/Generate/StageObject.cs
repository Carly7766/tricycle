using UnityEngine;

namespace Stage.Generate
{
    public class StageObject
    {
        public float width;
        public float posX;
        public GameObject gameObject;

        public StageObject(Stage stage, Vector3 generatedPos, GameObject gameObject)
        {
            width = stage.width;
            posX = generatedPos.x;
            this.gameObject = gameObject;
        }

        public void Destroy()
        {
            Object.Destroy(gameObject);
            gameObject = null;
        }
    }
}
