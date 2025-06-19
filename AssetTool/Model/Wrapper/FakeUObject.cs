namespace AssetTool
{
    public class FakeUObject : UObject
    {
        public PadData PadData { get; set; }

        public override ITransferible Move(Transfer transfer)
        {
            PadData ??= new PadData((int)transfer.GlobalObjects.CurrentObject.Size);
            PadData.Move(transfer);
            return this;
        }
    }
}
