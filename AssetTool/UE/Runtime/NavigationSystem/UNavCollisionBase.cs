namespace AssetTool.UE.Runtime.NavigationSystem
{
    public class UNavCollisionBase : UObject
    {
        public new UNavCollisionBase Read(BinaryReader reader)
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
