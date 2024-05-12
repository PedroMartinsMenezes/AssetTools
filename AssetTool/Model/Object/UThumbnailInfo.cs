namespace AssetTool
{
    public class UThumbnailInfo : UObject
    {
        public UThumbnailInfo Read(BinaryReader reader)
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
