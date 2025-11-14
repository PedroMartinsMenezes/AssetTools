namespace AssetTool
{
    [JsonAsset("ExampleCharacterFXEditor")]
    public class UExampleCharacterFXEditor : UBaseCharacterFXEditor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}