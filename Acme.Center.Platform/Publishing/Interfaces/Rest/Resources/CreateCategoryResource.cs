using System.ComponentModel.DataAnnotations;

namespace Acme.Center.Platform.Publishing.Interfaces.Rest.Resources;

/// <summary>
///     Create category resource for REST API
/// </summary>
/// <param name="Name">
///     The name of the category
/// </param>
public record CreateCategoryResource(
    [MaxLength(30, ErrorMessage = "The category name must not exceed 30 characters.")]
    string Name);