namespace AssetTool
{
    public class FakeUObject : UObject
    {
        public PadData PadData { get; set; }

        public override UObject Move(Transfer transfer)
        {
            PadData ??= new PadData((int)GlobalObjects.CurrentObject.Size);
            PadData.Move(transfer);
            return this;
        }
    }
}
