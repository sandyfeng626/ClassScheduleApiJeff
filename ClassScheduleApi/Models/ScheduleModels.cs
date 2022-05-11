namespace ClassScheduleApi.Models;

public record ClassInstanceModel(DateTime startDate, DateTime endDate);

public record ClassListModel(Dictionary<string, List<ClassInstanceModel>> data);