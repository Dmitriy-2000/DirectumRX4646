
// ==================================================================
// ModuleFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons.Functions
{
  internal static partial class Module
  {
    /// <redirect project="Sungero.Commons.Shared" type="Sungero.Commons.Shared.ModuleFunctions" />
    internal static global::System.String GetValueAsString(System.Object propertyValue)
    {
      var __typeName = "Sungero.Commons.Shared.ModuleFunctions";
      var __type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve(__typeName);
      if (__type != null)
      {
        var __instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(__type);
        var __methodInfo = __type.GetMethod("GetValueAsString", new global::System.Type[]{typeof(System.Object)});
        return (global::System.String)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__methodInfo, __instance, new object[]{propertyValue});
      }
      else
      {
        return global::Sungero.Commons.Shared.ModuleFunctions.GetValueAsString(propertyValue);
      }
    }
    /// <redirect project="Sungero.Commons.Shared" type="Sungero.Commons.Shared.ModuleFunctions" />
    internal static global::System.Boolean EntityParamsContainsKey(global::Sungero.Domain.Shared.IEntity entity, global::System.String paramName)
    {
      var __typeName = "Sungero.Commons.Shared.ModuleFunctions";
      var __type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve(__typeName);
      if (__type != null)
      {
        var __instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(__type);
        var __methodInfo = __type.GetMethod("EntityParamsContainsKey", new global::System.Type[]{typeof(global::Sungero.Domain.Shared.IEntity), typeof(global::System.String)});
        return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__methodInfo, __instance, new object[]{entity, paramName});
      }
      else
      {
        return global::Sungero.Commons.Shared.ModuleFunctions.EntityParamsContainsKey(entity, paramName);
      }
    }

    internal static class Remote
    {
      /// <redirect project="Sungero.Commons.Server" type="Sungero.Commons.Server.ModuleFunctions" />
      internal static global::Sungero.Commons.ICity CreateNewCity()
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.Commons.ICity>(
          global::System.Guid.Parse("459fa497-ee5b-49a4-9980-de00cada9b7a"),
          "CreateNewCity()");
      }

    }
    private static object GetFunctionsContainer()
    {
      return new global::Sungero.Commons.Shared.ModuleFunctions();
    }

    private static object GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType projectType, global::Sungero.Metadata.ModuleMetadata finalModuleMetadatda)
    {
      var assemblyName = finalModuleMetadatda.GetAssemblyName(projectType);
      var moduleFunctionsType = global::System.Type.GetType(global::System.String.Format("{0}.{1}, {2}", finalModuleMetadatda.FunctionNamespace, "Module", assemblyName));
      var methodInfo = moduleFunctionsType.GetMethod("GetFunctionsContainer", global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.Static);
      return global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, null, null);
    }
  }
}

// ==================================================================
// ModuleHyperlinks.g.cs
// ==================================================================

namespace Sungero.Commons
{
  public static class CommonsClientFunctionHyperlinksExtensions
  {
  }
}

// ==================================================================
// ModuleResources.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons.Shared
{
  public class ModuleResources : global::Sungero.Commons.IModuleResources
  {
    public virtual global::CommonLibrary.LocalizedString DuplicateDetected
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetString(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(System.Guid.Parse("459fa497-ee5b-49a4-9980-de00cada9b7a")) , "DuplicateDetected", false);
      }
    }

    public virtual global::CommonLibrary.LocalizedString DuplicateDetectedFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetString(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(System.Guid.Parse("459fa497-ee5b-49a4-9980-de00cada9b7a")), "DuplicateDetected", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString DuplicateNotFound
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetString(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(System.Guid.Parse("459fa497-ee5b-49a4-9980-de00cada9b7a")) , "DuplicateNotFound", false);
      }
    }

    public virtual global::CommonLibrary.LocalizedString DuplicateNotFoundFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetString(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(System.Guid.Parse("459fa497-ee5b-49a4-9980-de00cada9b7a")), "DuplicateNotFound", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString Empty
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetString(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(System.Guid.Parse("459fa497-ee5b-49a4-9980-de00cada9b7a")) , "Empty", false);
      }
    }

    public virtual global::CommonLibrary.LocalizedString EmptyFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetString(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(System.Guid.Parse("459fa497-ee5b-49a4-9980-de00cada9b7a")), "Empty", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString HasLinkedExternalEntities
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetString(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(System.Guid.Parse("459fa497-ee5b-49a4-9980-de00cada9b7a")) , "HasLinkedExternalEntities", false);
      }
    }

    public virtual global::CommonLibrary.LocalizedString HasLinkedExternalEntitiesFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetString(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(System.Guid.Parse("459fa497-ee5b-49a4-9980-de00cada9b7a")), "HasLinkedExternalEntities", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString RequiredPropertiesNotFilledIn
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetString(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(System.Guid.Parse("459fa497-ee5b-49a4-9980-de00cada9b7a")) , "RequiredPropertiesNotFilledIn", false);
      }
    }

    public virtual global::CommonLibrary.LocalizedString RequiredPropertiesNotFilledInFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetString(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(System.Guid.Parse("459fa497-ee5b-49a4-9980-de00cada9b7a")), "RequiredPropertiesNotFilledIn", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString LinkedEntityLocked
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetString(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(System.Guid.Parse("459fa497-ee5b-49a4-9980-de00cada9b7a")) , "LinkedEntityLocked", false);
      }
    }

    public virtual global::CommonLibrary.LocalizedString LinkedEntityLockedFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetString(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(System.Guid.Parse("459fa497-ee5b-49a4-9980-de00cada9b7a")), "LinkedEntityLocked", false, args);
    }

  }
}

// ==================================================================
// ModuleFoldersFilterStates.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons.Shared
{
}

// ==================================================================
// ModuleSharedPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons.Shared
{
  public partial class ModuleSharedPublicFunctions : global::Sungero.Commons.Shared.IModuleSharedPublicFunctions
  {
    public global::System.Boolean EntityParamsContainsKey(global::Sungero.Domain.Shared.IEntity entity, global::System.String paramName)
    {
      return global::Sungero.Commons.Functions.Module.EntityParamsContainsKey(entity, paramName);
    }
    public global::System.String GetValueAsString(System.Object propertyValue)
    {
      return global::Sungero.Commons.Functions.Module.GetValueAsString(propertyValue);
    }
  }
}

// ==================================================================
// ModuleWidgetParameters.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons.Shared
{  
}