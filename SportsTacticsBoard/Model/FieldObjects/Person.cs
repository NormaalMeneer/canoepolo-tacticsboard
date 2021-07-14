namespace TacticsBoard.FieldObjects
{
    abstract class Person : FieldObject
    {
        protected Person(float posX, float posY, float dispRadius) :
          base(posX, posY, dispRadius)
        {
        }

        protected Person(float posX, float posY, float dispRadiusX, float dispRadiusY) :
          base(posX, posY, dispRadiusX, dispRadiusY)
        {
        }
    }
}
