namespace AssetTool
{
    [JsonAsset("TextureFactory")]
    public class UTextureFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UDIMTextureFunctionLibrary")]
    public class UUDIMTextureFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}