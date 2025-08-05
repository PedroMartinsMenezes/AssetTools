namespace AssetTool
{
    public class FakeUObject : UObject
    {
        public WorkaroundPad PadData { get; set; }

        public override ITransferible Move(Transfer transfer)
        {
            PadData ??= new WorkaroundPad((int)transfer.GlobalObjects.CurrentObject.Size);
            PadData.Move(transfer);
            return this;
        }
    }
}
