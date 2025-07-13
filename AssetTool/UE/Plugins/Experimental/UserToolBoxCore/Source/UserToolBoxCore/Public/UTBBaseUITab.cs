namespace AssetTool
{
    [JsonAsset("UTBDefaultUITemplate")]
    public class UUTBDefaultUITemplate : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UTBToolBarTabUI")]
    public class UUTBToolBarTabUI : UUTBDefaultUITemplate
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UTBPaletteTabUI")]
    public class UUTBPaletteTabUI : UUTBToolBarTabUI
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UTBVerticalToolBarTabUI")]
    public class UUTBVerticalToolBarTabUI : UUTBToolBarTabUI
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UTBSlimHorizontalToolBarTabUI")]
    public class UUTBSlimHorizontalToolBarTabUI : UUTBToolBarTabUI
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}