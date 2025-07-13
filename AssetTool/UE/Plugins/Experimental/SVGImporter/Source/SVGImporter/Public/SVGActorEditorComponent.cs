namespace AssetTool
{
    [JsonAsset("SVGActorEditorComponent")]
    public class USVGActorEditorComponent : USceneComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}