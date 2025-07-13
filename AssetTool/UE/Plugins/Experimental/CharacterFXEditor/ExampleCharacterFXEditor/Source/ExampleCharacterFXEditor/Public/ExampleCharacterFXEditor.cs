namespace AssetTool
{
    [JsonAsset("ExampleCharacterFXEditor")]
    public class UExampleCharacterFXEditor : UBaseCharacterFXEditor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}