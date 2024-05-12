namespace AssetTool
{
    public class UNavCollisionBase : UObject
    {
        public UNavCollisionBase Read(BinaryReader reader)
        {
            base.Move(GlobalObjects.Transfer);
            return this;
        }
        public void Write(BinaryWriter writer)
        {
            base.Move(GlobalObjects.Transfer);
        }
    }
}
