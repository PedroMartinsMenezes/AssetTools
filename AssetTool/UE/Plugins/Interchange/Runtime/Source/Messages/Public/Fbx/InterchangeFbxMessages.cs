namespace AssetTool
{
    [JsonAsset("InterchangeResultMeshWarning")]
    public class UInterchangeResultMeshWarning : UInterchangeResultWarning
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InterchangeResultTextureDisplay")]
    public class UInterchangeResultTextureDisplay : UInterchangeResultDisplay_Generic
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InterchangeResultTextureWarning")]
    public class UInterchangeResultTextureWarning : UInterchangeResultWarning
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InterchangeResultMeshError")]
    public class UInterchangeResultMeshError : UInterchangeResultError
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InterchangeResultMeshWarning_Generic")]
    public class UInterchangeResultMeshWarning_Generic : UInterchangeResultMeshWarning
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InterchangeResultMeshError_Generic")]
    public class UInterchangeResultMeshError_Generic : UInterchangeResultMeshError
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InterchangeResultMeshWarning_TooManyUVs")]
    public class UInterchangeResultMeshWarning_TooManyUVs : UInterchangeResultMeshWarning
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InterchangeResultTextureDisplay_TextureFileDoNotExist")]
    public class UInterchangeResultTextureDisplay_TextureFileDoNotExist : UInterchangeResultTextureDisplay
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}