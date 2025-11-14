namespace AssetTool
{
    [JsonAsset("EditorFunctionalTest")]
    public class AEditorFunctionalTest : AFunctionalTest
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("EditorScreenshotFunctionalTest")]
    public class AEditorScreenshotFunctionalTest : AScreenshotFunctionalTest
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}