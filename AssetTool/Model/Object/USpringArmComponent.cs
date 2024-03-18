namespace AssetTool
{
    public class USpringArmComponent : USceneComponent
    {
        public new const string TypeName = "SpringArmComponent";

        public new USpringArmComponent Read(BinaryReader reader)
        {
            base.Read(reader);
            return this;
        }
        public new void Write(BinaryWriter writer)
        {
            base.Write(writer);
        }
    }
}
