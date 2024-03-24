public class sql_require {
    public static void main(String[] args) {
        String QUERY = "select * from students where ";
        String PARAMS = "{\"name\":\"Ivanov\", \"country\":\"Russia\", \"city\":\"Moscow\", \"age\":\"null\"} ";
        System.out.println(answer(QUERY, PARAMS));
    }

public static StringBuilder answer(String QUERY, String PARAMS) {
    String paramsNew = PARAMS.replace('{', ' ').replace('}', ' ');
    String[] params = paramsNew.split(",");
    StringBuilder stringBuilder = new StringBuilder(QUERY);

    for (int i = 0; i < params.length; i++) {
        String[] elements = params[i].replace('"', ' ').split(":");
        if (!"null".equals(elements[1].trim())) {
            stringBuilder.append(elements[0].trim()).append("=").append("'").append(elements[1].trim()).append("'");
            if (i < params.length - 2) stringBuilder.append(" and ");
        }
    }return stringBuilder;

}}