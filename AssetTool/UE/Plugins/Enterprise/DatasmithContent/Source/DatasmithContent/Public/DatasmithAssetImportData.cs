namespace AssetTool
{
    [JsonAsset("DatasmithAssetImportData")]
    public class UDatasmithAssetImportData : UAssetImportData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DatasmithStaticMeshImportData")]
    public class UDatasmithStaticMeshImportData : UDatasmithAssetImportData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DatasmithStaticMeshCADImportData")]
    public class UDatasmithStaticMeshCADImportData : UDatasmithStaticMeshImportData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DatasmithSceneImportData")]
    public class UDatasmithSceneImportData : UAssetImportData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DatasmithTranslatedSceneImportData")]
    public class UDatasmithTranslatedSceneImportData : UDatasmithSceneImportData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DatasmithCADImportSceneData")]
    public class UDatasmithCADImportSceneData : UDatasmithSceneImportData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DatasmithMDLSceneImportData")]
    public class UDatasmithMDLSceneImportData : UDatasmithSceneImportData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DatasmithGLTFSceneImportData")]
    public class UDatasmithGLTFSceneImportData : UDatasmithSceneImportData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DatasmithStaticMeshGLTFImportData")]
    public class UDatasmithStaticMeshGLTFImportData : UDatasmithStaticMeshImportData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DatasmithFBXSceneImportData")]
    public class UDatasmithFBXSceneImportData : UDatasmithSceneImportData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DatasmithDeltaGenAssetImportData")]
    public class UDatasmithDeltaGenAssetImportData : UDatasmithAssetImportData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DatasmithDeltaGenSceneImportData")]
    public class UDatasmithDeltaGenSceneImportData : UDatasmithFBXSceneImportData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DatasmithVREDAssetImportData")]
    public class UDatasmithVREDAssetImportData : UDatasmithAssetImportData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DatasmithVREDSceneImportData")]
    public class UDatasmithVREDSceneImportData : UDatasmithFBXSceneImportData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}