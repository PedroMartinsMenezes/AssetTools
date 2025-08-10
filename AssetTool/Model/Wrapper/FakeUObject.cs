namespace AssetTool
{
    public class FakeUObject : UObject
    {
        public WorkaroundPad PadData { get; set; } = new();

        public override ITransferible Move(Transfer transfer)
        {
            PadData.Move(transfer, transfer.GlobalObjects.CurrentObject.Size);
            return this;
        }
    }
}
